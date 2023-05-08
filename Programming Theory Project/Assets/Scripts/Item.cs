using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public abstract class Item : MonoBehaviour
{
	[SerializeField] string itemName;
	[SerializeField] int value;

	[SerializeField] protected TMP_Text descriptionText;

	public virtual void Description() { }

	public string GetItemName
	{
		get { return itemName; }
	}

	public string GetItemValue
	{
		get { return value.ToString() + "G"; }
	}
}
