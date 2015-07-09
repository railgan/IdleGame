using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatButton : MonoBehaviour {

	public int availableStatPoints{get;set;}
	public GameObject canvasButton;


	// Use this for initialization
	void Start () {
		canvasButton.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		checkButton();
		availableStatPoints = GameInformation.AvailableStatPoints;
	}

	void checkButton(){
		if(availableStatPoints > 0){
			canvasButton.SetActive(true);
		}
	}
}
