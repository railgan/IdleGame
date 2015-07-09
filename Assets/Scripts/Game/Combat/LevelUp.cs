using UnityEngine;
using System.Collections;

public class LevelUp 
{
	/**
	 * Levels Character, Adds Statpoints, Increases Req XP
	 */
	public void LevelUpCharacter(){
		GameInformation.PlayerLevel += 1; 
		GameInformation.CurrentXP = 0;
		GameInformation.AvailableStatPoints += 5;
		GameInformation.RequiredXP += GameInformation.PlayerLevel*1000; }
}

