using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayUserStatus : MonoBehaviour {
	private static LevelUp levelUpScript = new LevelUp();
	public Scrollbar XP_Bar;
	public Scrollbar Health_Bar;
	public float XpValue{get;set;}
	public float EnemyHealthValue{get;set;}


	public void Start() {
		if(GameInformation.RequiredXP == 0){
			GameInformation.RequiredXP = 1000;
		}
		CreateEnemy.CreateNewEnemy();
		//GameInformation.Damage = 15;
		DealDamage();
	}

	public void OnGUI() { 
		if(GUI.Button(new Rect(Screen.width/2-75,Screen.height/10*9,150,50), "Back")){
			Application.LoadLevel("Main_Menu");
			SaveInformation.SaveAllInformation();
		}
		GUILayout.Label("Current XP:" +GameInformation.CurrentXP + "\n" + "Required XP:" +GameInformation.RequiredXP + "\n" + "Level: " + 
		                GameInformation.PlayerLevel +  "\n" + "Damage: " + GameInformation.Damage + "\n" + "Enemy Health: " + CreateEnemy.curEnemy.curHealth
		                + " of "  + CreateEnemy.curEnemy.Health   +  "\n" + "Current Enemy: " + CreateEnemy.curEnemy.EnemyName + 
		                "\n" + "Available Statpoints: " + GameInformation.AvailableStatPoints);
		          
	}

	//Deals Damage to the Enemy
	public  void DmgCalculation(){
		CreateEnemy.curEnemy.curHealth -= GameInformation.Damage;
		CheckEnemyHealth();
	}
	public  void DealDamage(){
		InvokeRepeating("DmgCalculation",1,1.0f/GameInformation.Speed);
	}

	//Checks if Enemy is still alive
	public void CheckEnemyHealth()
	{ if(CreateEnemy.curEnemy.curHealth<= 0){
			IncreaseExperience.AddExperience();
			CreateEnemy.CreateNewEnemy();
		}
	}


	public void Update() {

		XpValue = ((float)GameInformation.CurrentXP / GameInformation.RequiredXP);
		XP_Bar.size = XpValue;
		EnemyHealthValue =((float)CreateEnemy.curEnemy.curHealth / CreateEnemy.curEnemy.Health);
		Health_Bar.size = EnemyHealthValue;
		}
	}
