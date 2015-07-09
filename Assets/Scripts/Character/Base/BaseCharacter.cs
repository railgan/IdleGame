using UnityEngine;
using System.Collections;

public class BaseCharacter : MonoBehaviour
{
	public int Defense{get;set;}
	public int Vitality{get;set;}
	public int curHealth{get;set;}
	public int Health{get;set;}
	public int Stamina{get;set;}
	public int Mana{get;set;}
	public int Armor{get;set;}

	public int Speed{get;set;}
	public int Strength{get;set;}
	public int Intellect{get;set;}
	public int Dexterity{get;set;}
	public int Damage{get;set;}

	public void	setStats(){
		GameInformation.Vitality = Vitality;
		GameInformation.Strength = Strength;
		GameInformation.Stamina = Stamina;
		GameInformation.curHealth = Health;
		GameInformation.Health = Health;
		GameInformation.Dexterity = Dexterity;
		GameInformation.Intellect = Intellect;
		GameInformation.Mana = Mana;
		GameInformation.Defense = Armor + Dexterity*5;
		GameInformation.Damage = (int)Strength*Speed/20;
	}
}

