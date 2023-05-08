using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE (Child of Item)
public class Weapon : Item
{
    [SerializeField] int minDamageValue;
	[SerializeField] int maxDamageValue;

	//POLYMORPHISM
	public override void Description()
	{
		base.descriptionText.text = "Damage Bonus: " + GetMinDamageValue +
			"-"+ GetMaxDamageValue +
			"\nSkill Bonus: +2 Lockpicking";
		//This item would grant +2 bonus on Lockpicking skill.
	}

	// ENCAPSULATION
	public int GetMinDamageValue
	{
		get { return minDamageValue; }
	}

	// ENCAPSULATION
	public int GetMaxDamageValue
	{
		get { return maxDamageValue; }
	}

}
