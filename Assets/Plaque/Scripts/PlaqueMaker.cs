using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlaqueMaker : MonoBehaviour
{
	public enum id
	{
		Zero,
		One,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Ten,
		Eleven,
		Twelve,
		Thirteen,
		Fourteen,
		Fifteen,
		Sixteen,
		Seventeen,
		Eighteen,
		Nineteen,
		Twenty
	}

	public id m_id = id.One;
	public TextMeshPro m_architectName;
	public TextMeshPro m_buildingName;
	public TextMeshPro m_quote;
	public SpriteRenderer m_colorBar;
	public SpriteRenderer m_icon;

	public BuildingInfo m_info;

	private Color m_color;

	void Start ()
	{
		DataReader dataObj = FindObjectOfType<DataReader> ();

		if (dataObj == null) {
			Debug.LogError ("No database found, killing myself now...");
			Destroy (this);
		}

		m_info = dataObj.m_data [(int)m_id];

		if (m_architectName)
			m_architectName.text = m_info.m_architect;
		if (m_buildingName)
			m_buildingName.text = m_info.m_buildingName;
		if (m_quote)
			m_quote.text = '\u201c' + m_info.m_quote + '\u201d';
		if (m_colorBar)
			m_colorBar.color = m_info.m_color;
		if (m_icon && m_info.m_sprite)
			m_icon.sprite = m_info.m_sprite;

	}
}
