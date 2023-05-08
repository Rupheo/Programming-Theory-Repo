using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    [SerializeField] int minDamageValue;
	[SerializeField] int maxDamageValue;

	public override void Description()
	{
		base.descriptionText.text = "Damage Bonus: " + GetMinDamageValue +
			"-"+ GetMaxDamageValue +
			"\nSkill Bonus: +2 Lockpicking";
		//This item would grant +2 bonus on Lockpicking skill.
	}

	public int GetMinDamageValue
	{
		get { return minDamageValue; }
	}

	public int GetMaxDamageValue
	{
		get { return maxDamageValue; }
	}

}
