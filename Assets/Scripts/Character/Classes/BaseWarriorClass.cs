using UnityEngine;
using System.Collections;

public class BaseWarriorClass : BaseCharacterClass {

	public BaseWarriorClass(){
		CharacterClassName = "Warrior";
		CharacterClassDescription = "Strong powerfull hero.";
		Vitality = 10;
		Stamina = 100;

		Health = Vitality * 4;
		Strength = 15;
		Dexterity = 10;
		Intellect = 8;
		Mana = Intellect*5;
		setStats();
	}


	}

