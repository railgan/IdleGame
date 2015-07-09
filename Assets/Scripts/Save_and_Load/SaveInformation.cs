using UnityEngine;
using System.Collections;

public class SaveInformation {
	public static void SaveAllInformation() {
		PlayerPrefs.SetString("PLAYERNAME", GameInformation.PlayerName);
		PlayerPrefs.SetInt("PLAYERLEVEL", GameInformation.PlayerLevel);
	//	PlayerPrefs.SetString("PLAYERCLASS", GameInformation.PlayerClass.ToString());
	//	PlayerPrefs.SetString("PLAYERRACE", GameInformation.PlayerRace.ToString());
		PlayerPrefs.SetInt("PLAYERSTAMINA", GameInformation.Stamina);
		PlayerPrefs.SetInt("PLAYERHEALTH", GameInformation.Health);
		PlayerPrefs.SetInt("PLAYERINTELLECT", GameInformation.Intellect);
		PlayerPrefs.SetInt("PLAYERSTRENGTH", GameInformation.Strength);
		PlayerPrefs.SetInt("PLAYERDEXTERITY", GameInformation.Dexterity);
		PlayerPrefs.SetInt("PLAYERMANA", GameInformation.Mana);
		PlayerPrefs.SetInt("PLAYERCURXP", GameInformation.CurrentXP);
		PlayerPrefs.SetInt("PLAYERREQXP", GameInformation.RequiredXP);
		PlayerPrefs.SetInt("PLAYERSTATPOINTSAV", GameInformation.AvailableStatPoints);
		PlayerPrefs.SetInt ("PLAYERVITALITY", GameInformation.Vitality);

		if(GameInformation.EquipmentOne != null){
			PPSerialization.Save("EQUIPMENT1", GameInformation.EquipmentOne);
	}
}
}
