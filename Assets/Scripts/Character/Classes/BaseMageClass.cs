using UnityEngine;
using System.Collections;

public class BaseMageClass : BaseCharacterClass {
	
	public BaseMageClass(){
		CharacterClassName = "Mage";
		CharacterClassDescription = "Wizard Kappa.";
		Vitality = 5;

		Stamina = 100;
		Health = Vitality * 4;
		Strength = 5;
		Dexterity = 8;
		Intellect = 15;
		Mana = Intellect*5;
		setStats();
		
		
	}

}
