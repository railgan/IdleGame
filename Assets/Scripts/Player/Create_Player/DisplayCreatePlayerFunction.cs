using UnityEngine;
using System.Collections;

public class DisplayCreatePlayerFunction : MonoBehaviour
{
	string characterName = "Name";
	private StatAllocationModule statAllocationModule = new StatAllocationModule();
	private int classSelection;
	private int raceSelection;
	private string[] classSelectionNames = new string[3] {"Mage", "Warrior", "Ranger"};
	private string[] raceSelectionNames = new string[4] {"Human", "Orc", "Elf", "Undead",};


	//Displays the selected Class with Description
	public void DisplayClassSelections(){
		classSelection = GUI.SelectionGrid(new Rect(50,50, 100, 300), classSelection, classSelectionNames, 1);
		GUI.Label(new Rect(Screen.width/2,50,300,300),"Description: " + FindClassDescription(classSelection));
		GUI.Label(new Rect(Screen.width/2,70,300,300), FindClassStatValues(classSelection));
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/4*3,100,50), "Choose Class")){
			ChooseClass(classSelection);
			CreaterPlayerGUI.currentState = CreaterPlayerGUI.CreatePlayerStates.RACESELECTION;
		}
		//Finds the description of the Selected class
	}
	private string FindClassDescription(int classSelection){
		BaseCharacterClass tempClass;
		if(classSelection == 0) {
			tempClass = new BaseMageClass();
			return tempClass.CharacterClassDescription;
		} else if(classSelection == 1) {
			tempClass = new BaseWarriorClass();
			return tempClass.CharacterClassDescription;
		} else if(classSelection == 2) {
			tempClass = new BaseRangerClass();
			return tempClass.CharacterClassDescription;
		} 
		return "No Class selected";
	}

	private string FindClassStatValues(int classSelection) {
		BaseCharacterClass tempClass;
		if(classSelection == 0) {
			tempClass = new BaseMageClass();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Mana: " +tempClass.Mana + "\n" + "Stamina: " + tempClass.Stamina  + "\n" + "Strength: " + tempClass.Strength
				+ "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity;
			return tempStats;
		}else if(classSelection == 1) {
			tempClass = new BaseWarriorClass();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Mana: " +tempClass.Mana + "\n" + "Stamina: " + tempClass.Stamina  + "\n" + "Strength: " + tempClass.Strength
				+ "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity;
			return tempStats;
		}else if(classSelection == 2) {
			tempClass = new BaseRangerClass();
			string tempStats = "Health: " + tempClass.Health + "\n" + "Mana: " +tempClass.Mana + "\n" + "Stamina: " + tempClass.Stamina  + "\n" + "Strength: " + tempClass.Strength
				+ "\n" + "Intellect: " + tempClass.Intellect + "\n" + "Dexterity: " + tempClass.Dexterity;
			return tempStats;
		}
		return "";
	}

	private void ChooseClass(int classSelection){
		if (classSelection == 0) // Mage
		{GameInformation.PlayerClass=new BaseMageClass();
		}
		if (classSelection == 1) //Warrior
		{GameInformation.PlayerClass=new BaseWarriorClass();
		}
		if (classSelection == 2)//Ranger
		{GameInformation.PlayerClass=new BaseRangerClass();
		}
	}
	

	//Displays the selected Race with Description
	public void DisplayRaceSelection(){
		raceSelection = GUI.SelectionGrid(new Rect(50,50, 100, 300), raceSelection, raceSelectionNames, 1);
		GUI.Label(new Rect(Screen.width/2,50,300,300), FindRaceDescrption(raceSelection));
		GUI.Label(new Rect(Screen.width/2,70,300,300), FindRaceStatValues(raceSelection));
		if(GUI.Button(new Rect(Screen.width/2+100,Screen.height/4*3,100,50), "Back")){
			CreaterPlayerGUI.currentState = CreaterPlayerGUI.CreatePlayerStates.CLASSSELECTION;
		}
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/4*3,100,50), "Choose Race")){
			ChooseRace(raceSelection);
			CreaterPlayerGUI.currentState = CreaterPlayerGUI.CreatePlayerStates.STATALLOCATION;
		}
	}
	//Finds the description of the Selected race
	private string FindRaceDescrption(int raceSelection){
		BaseCharacterRace tempRace;
		if(raceSelection == 0) {
			tempRace = new BaseHumanRace();
			return tempRace.CharacterRaceDescription;
		} else if(raceSelection == 1) {
			tempRace = new BaseOrcRace();
			return tempRace.CharacterRaceDescription;
		} else if(raceSelection == 2) {
			tempRace = new BaseElfRace();
			return tempRace.CharacterRaceDescription;
		} else if(raceSelection == 3) {
			tempRace = new BaseUndeadRace();
			return tempRace.CharacterRaceDescription;
		}
		return "No Race selected";
	}

	private string FindRaceStatValues(int raceSelection) {
		BaseCharacterRace tempRace;
		if(raceSelection == 0) {
			tempRace = new BaseHumanRace();
			string tempStats = "Strength: " + tempRace.Strength + "\n" + "Intellect: " + tempRace.Intellect + "\n" + "Dexterity: " + tempRace.Dexterity;
			return tempStats;
		}else if(raceSelection == 1) {
			tempRace = new BaseOrcRace();
			string tempStats = "Strength: " + tempRace.Strength + "\n" + "Intellect: " + tempRace.Intellect + "\n" + "Dexterity: " + tempRace.Dexterity;
			return tempStats;
		}else if(raceSelection == 2) {
			tempRace = new BaseElfRace();
			string tempStats = "Strength: " + tempRace.Strength + "\n" + "Intellect: " + tempRace.Intellect + "\n" + "Dexterity: " + tempRace.Dexterity;
			return tempStats;
		}else if(raceSelection == 3) {
			tempRace = new BaseUndeadRace();
			string tempStats = "Strength: " + tempRace.Strength + "\n" + "Intellect: " + tempRace.Intellect + "\n" + "Dexterity: " + tempRace.Dexterity;
			return tempStats;
	}
		return "";
	}
	//Chooses the selected Race
	private void ChooseRace(int raceSelection){
		if (raceSelection == 0) // Human
		{GameInformation.PlayerRace=new BaseHumanRace();
		}
		if (raceSelection == 1) //Orc
		{GameInformation.PlayerRace=new BaseOrcRace();
		}
		if (raceSelection == 2)//Elf
		{GameInformation.PlayerRace=new BaseElfRace();
		}
		if (raceSelection == 3)//Undead
		{GameInformation.PlayerRace=new BaseUndeadRace();
		}
	}
	
	public void DisplayStatAllocation(){

		statAllocationModule.DisplayStatAllocationModule();

		}

	public void FindFinalStats(){
		GUI.Label (new Rect(Screen.width/2, 50,300,300), "Health: "+ GameInformation.Health + "\n" + "Mana: " + GameInformation.Mana+ "\n" + "Stamina: " + GameInformation.Stamina + "\n" + 
			"Vitality: " + GameInformation.Vitality + "\n" + "Strength: "+ GameInformation.Strength + "\n" + "Dexterity: " + GameInformation.Dexterity + "\n" + "Intellect :" + GameInformation.Intellect + "\n" + "Damage :" + GameInformation.Damage);
	}
	public void DisplayFinalSetup(){
		//Back Button
		if(GUI.Button(new Rect(Screen.width/2+100,Screen.height/4*3,100,50), "Back")){
			CreaterPlayerGUI.currentState = CreaterPlayerGUI.CreatePlayerStates.STATALLOCATION;
		}
		characterName = GUI.TextField(new Rect(350,350,150,50), characterName);
		FindFinalStats();
		if(characterName != "Name"){
		if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/4*3,100,50), "Done")){
			GameInformation.PlayerLevel = 1;
			GameInformation.RequiredXP = 1000;
			GameInformation.CurrentXP = 0;
			GameInformation.PlayerName=characterName;
			SaveInformation.SaveAllInformation();
			Application.LoadLevel("Main_Menu");
		}
	}

	}



	public void DisplayMainItems() {
		var centeredStyle = GUI.skin.GetStyle("Label");
		centeredStyle.alignment = TextAnchor.UpperCenter;
		GUI.Label (new Rect(Screen.width/2-100, 20, 100, 50), "CREATE NEW PLAYER", centeredStyle);
	}

}

