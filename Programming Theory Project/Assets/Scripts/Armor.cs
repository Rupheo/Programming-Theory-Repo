using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE (Child of Item)
public class Armor : Item
{
    [SerializeField] int defenseValue;

	//POLYMORPHISM
	public override void Description()
	{
		base.descriptionText.text = "Defense Bonus: " + GetDefenseValue +
			"\nHealth Regen Bonus: 2";
		//This Item would have an Health Regen 
	}

	// ENCAPSULATION
	public int GetDefenseValue
	{
		get { return defenseValue; }
	}	
}
