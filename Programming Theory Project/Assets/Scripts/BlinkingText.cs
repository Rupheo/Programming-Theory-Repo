using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BlinkingText : MonoBehaviour
{
	[SerializeField] float blinkTimer = 0.5f;

	private TMP_Text text;
	private Color tempColor;
	private Color currentColor; 

	private void Start()
	{
		text = GetComponent<TMP_Text>();
		tempColor = text.color;
		StartCoroutine(nameof(StartTextBlink));
	}

	private void StopTextBlink()
	{
		StopCoroutine(nameof(StartTextBlink));
		tempColor.a = 1;
		text.color = tempColor;
	}

	IEnumerator StartTextBlink()
	{
		while (true)
		{
			yield return new WaitForSeconds(blinkTimer);
			tempColor.a = 0;
			text.color = tempColor;
			yield return new WaitForSeconds(blinkTimer);
			tempColor.a = 1;
			text.color = tempColor;
		}
	}
}
