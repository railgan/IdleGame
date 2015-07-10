using UnityEngine;
using System.Collections;

public class StatScreen : MonoBehaviour
{
	private string[] statNames = new string[4] {"Vitality", "Intellect", "Strength", "Dexterity", };
	private string[] statDescriptions = new string[4]{"Health modifier","Magical damage modifier", "Physical damage modifier", "Speed modifier",};
	private bool[] statSelections = new bool[4];
	private int[] pointsToAllocate = new int[10];
	private int[] baseStatPoints = new int[10];
	private bool didRunOnce = false;
	private int availPoints = GameInformation.AvailableStatPoints;
	
	public void DisplayStatAllocationModule() {
		if(!didRunOnce){
			RetrieveStatPoints();
			didRunOnce = true;
		}
		if(GUI.Button(new Rect(Screen.width/2+100,Screen.height/4*3,100,50), "Back")){
			didRunOnce = false;
			Reset();
		}
		
		GUI.Label(new Rect(Screen.width/5*4,100,200,50),"Available Statpoints: " + availPoints);
		DisplayStatToggleSwitches();
		DisplayStatIncreaseDecreaseButtons();
		if(availPoints == 0){
			if(GUI.Button(new Rect(Screen.width/2-100,Screen.height/4*3,100,50), "Save Stats")){
				GameInformation.Vitality=pointsToAllocate[0];
				GameInformation.Intellect=pointsToAllocate[1];
				GameInformation.Strength=pointsToAllocate[2];
				GameInformation.Dexterity=pointsToAllocate[3];
				GameInformation.CalculateStats();
				CreaterPlayerGUI.currentState = CreaterPlayerGUI.CreatePlayerStates.FINALSETUP;
			}
		}
	}
	
	public void DisplayStatToggleSwitches(){
		for(int i = 0; i < statNames.Length; i++){
			statSelections[i] = GUI.Toggle (new Rect(10,60*i+10,100,40), statSelections[i], statNames[i]);
			GUI.Label(new Rect( 100,60*i+10,50,50), pointsToAllocate[i].ToString());
			if(statSelections[i]){
				GUI.Label(new Rect(20,60*i+30,100,40), statDescriptions[i]);
			}
		}
	}
	
	private void DisplayStatIncreaseDecreaseButtons(){
		for(int i = 0; i< statSelections.Length; i++){
			if(availPoints > 0) {
				if(GUI.Button(new Rect(200,60*i,50,50), "+")){
					pointsToAllocate[i] += 1;
					--availPoints;
				}
			}
			if( pointsToAllocate[i] > baseStatPoints[i]){
				if(GUI.Button(new Rect(260,60*i,50,50), "-")){
					pointsToAllocate[i] -=1;
					++availPoints;
				}
			}
		}
		
	}
	private void Reset(){
		pointsToAllocate = new int[10];
		baseStatPoints = new int[10];
		availPoints = GameInformation.AvailableStatPoints;
	}
	
	public void RetrieveStatPoints(){
		BaseCharacterClass playerClass = GameInformation.PlayerClass;
		BaseCharacterRace playerRace = GameInformation.PlayerRace;
		GameInformation.Dexterity += GameInformation.PlayerRace.Dexterity;
		GameInformation.Strength += GameInformation.PlayerRace.Strength;
		GameInformation.Intellect += GameInformation.PlayerRace.Intellect;
		pointsToAllocate[0] = GameInformation.Vitality;
		baseStatPoints[0] = GameInformation.Vitality;
		pointsToAllocate[1] =GameInformation.Intellect;
		baseStatPoints[1] = GameInformation.Intellect;
		pointsToAllocate[2] = GameInformation.Strength;
		baseStatPoints[2] = GameInformation.Strength;
		pointsToAllocate[3] = GameInformation.Dexterity;
		baseStatPoints[3] = GameInformation.Dexterity;
		
	}
	
	
	
	
	
}
