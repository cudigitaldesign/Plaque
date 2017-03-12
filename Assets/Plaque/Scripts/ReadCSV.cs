using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCSV : MonoBehaviour
{

	public TextAsset m_data;
	// Use this for initialization
	void Start ()
	{

		string[][] readFile;

		readFile = Read (m_data);

		foreach (string[] s in readFile) {
			foreach (string str in s)
				Debug.Log (str.ToString ());
		}

		for (int i = 0; i < readFile.Length; i++) {
			string str = "";
			foreach (string s in readFile[i]) {
				str += s;
			}

			Debug.Log (str);
		}
	}
	
	// Reads CSV into a jagged array of strings
	public string[][] Read (TextAsset csvFile)
	{
		string[][] allStringsByWord;
		string[] allStringsByLine = csvFile.text.Split ('\n');
		allStringsByWord = new string [allStringsByLine.Length][];
		for (int i = 0; i < allStringsByLine.Length; i++) { 
			allStringsByWord [i] = allStringsByLine [i].Split (',');
		}
		return allStringsByWord;
	}
}
