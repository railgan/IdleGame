using UnityEngine;
using System.Collections;

public class DisplayLoadPlayer : MonoBehaviour {
	void OnGUI(){
	GUI.Label (new Rect(Screen.width/2, 50,300,300), "Name: " + GameInformation.PlayerName + "\n" + "Class: " + GameInformation.PlayerClass.CharacterClassName + "\n" + "Race: " + GameInformation.PlayerRace.CharacterRaceName + "\n" + "Health: "+
		        GameInformation.Health + "\n" + "Mana: " + GameInformation.Mana+ "\n" + "Stamina: " + GameInformation.Stamina + "\n" + 
	           "Vitality: " + GameInformation.Vitality + "\n" + "Strength: "+ GameInformation.Strength + "\n" + "Dexterity: " + 
		           GameInformation.Dexterity + "\n" + "Intellect :" + GameInformation.Intellect);
	}
}
