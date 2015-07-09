using UnityEngine;
using System.Collections;

public class DisplayMainMenu : MonoBehaviour
{
	void Start (){
	LoadInformation.LoadAllInformation();
	}
	public void OnGUI(){
		if(GUI.Button(new Rect(Screen.width/2-75,100,150,50), "New Character")){
			ResetStats.ResetLevel();
			Application.LoadLevel("Character_Creation");
		}
		if(GUI.Button(new Rect(Screen.width/2-75,250,150,50), "Options")){
	}
		if(GUI.Button(new Rect(Screen.width/2-75,325,150,50), "Close")){
			Application.Quit();
		}
	if (GameInformation.PlayerName != null){
			if(GUI.Button(new Rect(Screen.width/2-75,175,150,50), "Load")){
				Application.LoadLevel("Gameplay");
				}
		}
	}
}

