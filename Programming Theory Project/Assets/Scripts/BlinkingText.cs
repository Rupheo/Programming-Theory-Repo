using System.Collections;
using TMPro;
using UnityEngine;

public class BlinkingText : MonoBehaviour
{
	[SerializeField] float blinkTimer = 0.55f;

	private void Start()
	{
		StartCoroutine(nameof(StartTextBlink));
	}

	IEnumerator StartTextBlink()
	{
		while (true)
		{
			yield return new WaitForSeconds(blinkTimer);
			GetComponent<TMP_Text>().enabled = false;
			yield return new WaitForSeconds(blinkTimer);
			GetComponent<TMP_Text>().enabled = true;
		}
	}

	private void StopTextBlink()
	{
		StopCoroutine(nameof(StartTextBlink));
	}
}
