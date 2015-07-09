using UnityEngine;
using System.Collections;

public class EnemyList : BaseEnemy
{
	public static BaseEnemy newEnemy = new BaseEnemy();

	public static void setEnemyStats(){
		newEnemy.Speed = newEnemy.Dexterity/20+10;
		newEnemy.Damage =(int)newEnemy.Strength*newEnemy.Speed/20;
		newEnemy.Health = newEnemy.Vitality * 15;
		newEnemy.curHealth = newEnemy.Health;
		newEnemy.Mana = newEnemy.Intellect*5;
		newEnemy.Defense = newEnemy.Armor + newEnemy.Dexterity*5;
	}

	public static BaseEnemy ChooseEnemy(int enemySelection){
		if (enemySelection == 0){
			newEnemy.EnemyName = "Debug";
			newEnemy.EnemyDescription = "It's Bugged";
			newEnemy.XpToGive = 10;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 5;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			setEnemyStats();
			return newEnemy;

		}else if (enemySelection == 1){
			newEnemy.EnemyName = "Enemy1";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 5;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 25;
			newEnemy.Armor = 5;
			newEnemy.Strength = 13;
			newEnemy.Intellect = 8;
			newEnemy.Dexterity = 12;
			 setEnemyStats();
			return newEnemy;

		}else if (enemySelection == 2){
			newEnemy.EnemyName = "Enemy2";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 25;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 50;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			 setEnemyStats();
			return newEnemy;
		}else if (enemySelection == 3){
			newEnemy.EnemyName = "Enemy3";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 10;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 5;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			 setEnemyStats();
			return newEnemy;

		}else if (enemySelection == 4){
			newEnemy.EnemyName = "Enemy4";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 10;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 5;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			 setEnemyStats();
			return newEnemy;

		}else if (enemySelection == 5){
			newEnemy.EnemyName = "Enemy";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 10;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 5;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			 setEnemyStats();
			return newEnemy;

		}else if (enemySelection == 6){
			newEnemy.EnemyName = "Enemy5";
			newEnemy.EnemyDescription = "A Weak Individual";
			newEnemy.XpToGive = 10;
			newEnemy.GoldToGive = 10;
			newEnemy.Stamina = 5;
			newEnemy.Vitality = 5;
			newEnemy.Armor = 5;
			newEnemy.Strength = 5;
			newEnemy.Intellect = 5;
			newEnemy.Dexterity = 5;
			 setEnemyStats();
			return newEnemy;
		} else {return ChooseEnemy(0);
		}

	}



}

