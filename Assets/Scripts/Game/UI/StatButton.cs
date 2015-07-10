using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StatButton : MonoBehaviour {

	public int availableStatPoints{get;set;}
	public Button canvasButton;


	// Use this for initialization
	void Start () {
		canvasButton.GetComponent<CanvasGroup>().alpha = 0;
		canvasButton.onClick.AddListener(() =>	Application.LoadLevel("StatScreen"));
	}


	
	// Update is called once per frame
	void Update () {
		checkButton();
		availableStatPoints = GameInformation.AvailableStatPoints;
	}

	void checkButton(){
		if(availableStatPoints > 0){
			canvasButton.GetComponent<CanvasGroup>().alpha = 1;
		}

}
}
	