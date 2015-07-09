using UnityEngine;
using System.Collections;

public class BaseRangerClass : BaseCharacterClass
{
	public  BaseRangerClass() {
		CharacterClassName = "Ranger";
		CharacterClassDescription = "WHAT AN ANIMAL.";
		Vitality = 8;

		Stamina = 100;
		Health = Vitality * 4;
		Strength = 10;
		Dexterity = 15;
		Intellect = 8;
		Mana = Intellect*5;
		setStats();
	}

}

