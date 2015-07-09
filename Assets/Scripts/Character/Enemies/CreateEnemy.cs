using UnityEngine;
using System.Collections;

public class CreateEnemy 
{
	public static BaseEnemy curEnemy = new BaseEnemy();
	private static int enemySelection;

	public static BaseEnemy CreateNewEnemy(){
		enemySelection = Random.Range(1,6);
		curEnemy = EnemyList.ChooseEnemy(enemySelection);
		return curEnemy;
	}
}

