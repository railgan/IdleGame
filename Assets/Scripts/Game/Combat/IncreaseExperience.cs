using UnityEngine;
using System.Collections;

public class IncreaseExperience {

	private static int XpToGive;
	private static LevelUp levelUpScript = new LevelUp();

	public static void AddExperience(){
		XpToGive = CreateEnemy.curEnemy.XpToGive;
		GameInformation.CurrentXP += XpToGive;
		LevelUpCheck();

	}
	/**
	 * Checks if Character has a Level-Up
*/
	public static void LevelUpCheck(){
		if( GameInformation.CurrentXP>= GameInformation.RequiredXP) {
			levelUpScript.LevelUpCharacter();
		}
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
