using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatButton : MonoBehaviour {

	public int availableStatPoints{get;set;}
	public Button canvasButton;


	// Use this for initialization
	void Start () {
		canvasButton.GetComponent<CanvasGroup>().alpha = 0;
		//canvasButton.onClick.AddListener(() =>	Application.LoadLevel("StatScreen"));
		canvasButton.onClick.AddListener(() =>	GameInformation.AvailableStatPoints = 0); //Test sets statpoints to 0
		canvasButton.onClick.AddListener(() =>	GameInformation.Strength += 5); // Test sets Strength +5 
		canvasButton.onClick.AddListener(() =>	GameInformation.CalculateStats()); // Test calculates the stats
	}


	
	// Update is called once per frame
	void Update () {
		availableStatPoints = GameInformation.AvailableStatPoints;
		checkButton();

	}

	void checkButton(){
		if(availableStatPoints > 0){
			canvasButton.GetComponent<CanvasGroup>().alpha = 1;
		} else { 
			canvasButton.GetComponent<CanvasGroup>().alpha = 0;
		}

}
}
	