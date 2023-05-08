using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//INHERITANCE (Parent)

public abstract class Item : MonoBehaviour
{
	[SerializeField] string itemName;
	[SerializeField] int value;

	[SerializeField] protected TMP_Text descriptionText;

	public virtual void Description() { }

	// ENCAPSULATION
	public string GetName
	{
		get { return itemName; }
	}

	// ENCAPSULATION
	public string GetValue
	{
		get { return value.ToString() + "G"; }
	}
}
