using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Armor : Item
{
    [SerializeField] int defenseValue;

	public override void Description()
	{
		base.descriptionText.text = "Defense Bonus: " + GetDefenseValue +
			"\nHealth Regen Bonus: 2";
		//This Item would have an Health Regen 
	}

	public int GetDefenseValue
	{
		get { return defenseValue; }
	}	
}
