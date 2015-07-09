using UnityEngine;
using System.Collections;

public class CreaterPlayerGUI : MonoBehaviour
{


	public enum CreatePlayerStates{
		CLASSSELECTION, //Displays classes
		RACESELECTION,	//Displays Races
		STATALLOCATION, // Displays Stats
		FINALSETUP,	//Name etc
	}

	private DisplayCreatePlayerFunction displayFunctions = new DisplayCreatePlayerFunction();
	
	public static CreatePlayerStates currentState;



	// Use this for initialization
	void Start ()
	{
		currentState = CreatePlayerStates.CLASSSELECTION;
	}
	
	// Update is called once per frame
	void Update ()
	{
		switch(currentState){
		case(CreatePlayerStates.CLASSSELECTION):
			break;
		case(CreatePlayerStates.RACESELECTION):
			break;
		case(CreatePlayerStates.STATALLOCATION):
			break;
		case(CreatePlayerStates.FINALSETUP):
			break;
		}
	}

	void OnGUI(){
		displayFunctions.DisplayMainItems();
		if(GUI.Button(new Rect(Screen.width/5*4,Screen.height/4*3,100,50), "Cancel")){
			Application.LoadLevel("Main_Menu");
		}

		//Turns the player
		Transform player = GameObject.FindGameObjectWithTag("Player").transform;
		if(GUI.Button(new Rect(300,350,50,50), "<<<")){
			//turn transform tagged as player to the left
			player.Rotate(Vector3.up*5);
		}
		if(GUI.Button(new Rect(500,350,50,50), ">>>")){
			//turn transform tagged as player to the right))
			player.Rotate(Vector3.down*5);

		}

		if(currentState == CreatePlayerStates.CLASSSELECTION){
			displayFunctions.DisplayClassSelections();

			}
		if(currentState == CreatePlayerStates.RACESELECTION){
			displayFunctions.DisplayRaceSelection();
			}
		if(currentState == CreatePlayerStates.STATALLOCATION){
			displayFunctions.DisplayStatAllocation();
		}
		if(currentState == CreatePlayerStates.FINALSETUP){
			displayFunctions.DisplayFinalSetup();
		}
}
}



