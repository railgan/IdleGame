using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Todo: Enemy Attackspeed Calculation doesn't change upon loading of new Enemy???

public class DisplayUserStatus : MonoBehaviour {
	private static LevelUp levelUpScript = new LevelUp();
	public Scrollbar XP_Bar;
	public Scrollbar Health_Bar;
	public Scrollbar PlayerHealth_Bar;
	public float XpValue{get;set;}
	public float EnemyHealthValue{get;set;}
	public float PlayerHealthValue{ get; set; }
	public CreateItem itemcreater = new CreateItem ();


	public void Start() {
		if(GameInformation.RequiredXP == 0){
			GameInformation.RequiredXP = 1000;
		}
		CreateEnemy.CreateNewEnemy();
		DealDamage();
	}

	public void OnGUI() { 
		if (GameInformation.AvailableStatPoints > 0) {
			if (GUI.Button (new Rect (Screen.width / 2 - 50, Screen.height / 6, 100, 50), "Stat Allocaiton")) {
				// to be added
			}
		}
		if(GUI.Button(new Rect(Screen.width/2-75,Screen.height/10*9,150,50), "Back")){
			Application.LoadLevel("Main_Menu");
			SaveInformation.SaveAllInformation();
		}
		GUILayout.Label("Current XP:" +GameInformation.CurrentXP + "\n" + "Required XP:" +GameInformation.RequiredXP + "\n" + "Level: " + 
		                GameInformation.PlayerLevel +  "\n"  + "Player Health: " + GameInformation.curHealth + "\n" + "Damage: " + GameInformation.Damage + "\n" + "Enemy Health: " + CreateEnemy.curEnemy.curHealth
		                + " of "  + CreateEnemy.curEnemy.Health   +  "\n" + "Current Enemy: " + CreateEnemy.curEnemy.EnemyName + 
		                "\n" + "Available Statpoints: " + GameInformation.AvailableStatPoints
		              //  + "\n" + "Head: "+ GameInformation.EquipmentHead.ItemName
		                );
		          
	}

	//Deals Damage to the Enemy
	public  void DmgCalculation(){
		CreateEnemy.curEnemy.curHealth -= GameInformation.Damage;
		CheckEnemyHealth();
	}
	//Deals Damage to the Player
	public void EnemyDmgCalculation(){
		GameInformation.curHealth -= CreateEnemy.curEnemy.Damage;
		CheckPlayerHealth ();
	}
	//Calls the Damage Functions
	public  void DealDamage(){
		InvokeRepeating("DmgCalculation",1,1.0f/GameInformation.Speed);
		InvokeRepeating ("EnemyDmgCalculation", 1, 1.0f / CreateEnemy.curEnemy.Speed);
	}

	//Checks if Enemy is still alive
	public void CheckEnemyHealth()
	{ if(CreateEnemy.curEnemy.curHealth<= 0){
	GameInformation.curHealth  = GameInformation.Health; // makes it so the player can't die
			IncreaseExperience.AddExperience();
			itemcreater.CreateEquipment();
			CreateEnemy.CreateNewEnemy();
		}
	}
	//Checks if Player is still alive
	public void CheckPlayerHealth(){
		if (GameInformation.curHealth <= 0) {
			Application.LoadLevel ("Main_Menu");
		}
	}


	public void Update() {

		XpValue = ((float)GameInformation.CurrentXP / GameInformation.RequiredXP);
		XP_Bar.size = XpValue;
		EnemyHealthValue =((float)CreateEnemy.curEnemy.curHealth / CreateEnemy.curEnemy.Health);
		Health_Bar.size = EnemyHealthValue;
		PlayerHealthValue = ((float)GameInformation.curHealth / GameInformation.Health);
		PlayerHealth_Bar.size = PlayerHealthValue;
		}
	}
