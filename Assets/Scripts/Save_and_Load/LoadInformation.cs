using UnityEngine;
using System.Collections;

public class LoadInformation : MonoBehaviour
{
	public static void LoadAllInformation() {
		GameInformation.PlayerName =PlayerPrefs.GetString("PLAYERNAME");
		GameInformation.PlayerLevel =PlayerPrefs.GetInt("PLAYERLEVEL");
		GameInformation.Stamina =PlayerPrefs.GetInt("PLAYERSTAMINA");
		GameInformation.Health =PlayerPrefs.GetInt("PLAYERHEALTH");
		GameInformation.Intellect =PlayerPrefs.GetInt("PLAYERINTELLECT");
		GameInformation.Strength =PlayerPrefs.GetInt("PLAYERSTRENGTH");
		GameInformation.Dexterity =PlayerPrefs.GetInt("PLAYERDEXTERITY");
		GameInformation.Mana =PlayerPrefs.GetInt("PLAYERMANA");
		GameInformation.CurrentXP = PlayerPrefs.GetInt("PLAYERCURXP");
		GameInformation.RequiredXP = PlayerPrefs.GetInt("PLAYERREQXP");
		GameInformation.AvailableStatPoints = PlayerPrefs.GetInt("PLAYERSTATPOINTSAV");

		if(PlayerPrefs.GetString("EQUIPMENT1") != null){
			GameInformation.EquipmentOne = (BaseEquipment)PPSerialization.Load("EQUIPMENT1");
		}

	}

}

