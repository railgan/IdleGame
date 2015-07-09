using UnityEngine;
using System.Collections;

public class CreateNewPotion : MonoBehaviour
{
	public BasePotion newPotion;
	// Use this for initialization
	void Start ()
	{
	
	}

	public BasePotion CreatePotion() {
		newPotion = new BasePotion();
		newPotion.ItemName = "Potion";
		newPotion.ItemDescription = "This is a potion.";
		newPotion.ItemID = Random.Range(1,101);
		ChoosePotionType();	
		return newPotion;
	}

	public void ChoosePotionType(){
		switch (Random.Range(1,5))
		{
		case 4:
			newPotion.PotionType = BasePotion.PotionTypes.ENERGY;
			break;
		case 3:
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
			break;
		case 2:
			newPotion.PotionType = BasePotion.PotionTypes.STATS;
			break;
		case 1:
			newPotion.PotionType = BasePotion.PotionTypes.SPECIAL;
			break;
		}
	}

}

