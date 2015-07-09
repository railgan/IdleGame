using UnityEngine;
using System.Collections;

public class BasePlayer 
{
	public string PlayerName{get;set;}
	public string Classname{get;set;}
	public int PlayerLevel{get;set;}
	public BaseCharacterClass PlayerClass{get;set;}

	public int Health{get;set;}
	public int Stamina{get;set;}
	public int Mana{get;set;}
	
	public int Strength{get;set;}
	public int Intellect{get;set;}
	public int Dexterity{get;set;}

	public int Gold{get;set;}
	
	public int CurrentXP{get;set;}
	public int RequiredXP{get;set;}
	public int AvailableStatPoints{get;set;}

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

