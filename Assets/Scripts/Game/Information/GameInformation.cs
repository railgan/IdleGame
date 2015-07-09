using UnityEngine;
using System.Collections;

public class GameInformation : MonoBehaviour {

	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	public static BaseCharacterRace PlayerRace{get;set;}
	public static BaseEquipment EquipmentOne{get;set;}
	public static string PlayerName{get;set;}
	public static int PlayerLevel{get;set;}
	public static BaseCharacterClass PlayerClass{get;set;}
	public static int Vitality {get;set;}
	public static int Stamina {get;set;}
	public static int Health {get;set;}
	public static int curHealth{get;set;}
	public static int Mana {get;set;}
	public static int Intellect {get;set;}
	public static int Strength {get;set;}
	public static int Dexterity {get;set;}
	public static int CurrentXP {get;set;}
	public static int RequiredXP {get;set;}
	public static int AvailableStatPoints {get;set;}
	public static int Gold{get;set;}
	public static int Armor{get;set;}
	public static int Defense{get;set;}
	public static int Damage{get;set;}
	public static int Speed{get;set;}
	public static int AttackValue{get;set;}
	public static int Attack{get;set;}
	public static BaseEquipment EquipmentHead{get;set;}
	public static BaseEquipment EquipmentShoulders{get;set;}
	public static BaseEquipment EquipmentChest{get;set;}
	public static BaseEquipment EquipmentLegs{get;set;}
	public static BaseWeapon EquipmentWeapon{get;set;}
	public static BaseEquipment EquipmentBelt{get;set;}
	public static BaseEquipment EquipmentBracers{get;set;}
	public static BaseEquipment EquipmentFeet{get;set;}
	public static BaseEquipment EquipmentHands{get;set;}
	public static BaseEquipment EquipmentRing{get;set;}






	public static void CalculateStats(){
		 Speed =  Dexterity/20+10;
		Attack = (Strength+Intellect)*3+AttackValue;
		 Damage = (int)Attack*Speed/20;
		 Health =  Vitality * 15;
		 curHealth =  Health;
		 Mana =  Intellect*5;
		 Defense =  Armor +  Dexterity*5;
	}
}
