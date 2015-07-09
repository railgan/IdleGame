using UnityEngine;
using System.Collections;

public class CreateNewEquipment
{
	public BaseEquipment newEquipment;
	public string[] itemNames = new string[4]{"Common", "Great", "Amazing", "Insane"};
	public string[] itemDescriptions = new string[2]{"A new cool item", "an old item"};



	public BaseEquipment CreateEquipment(){
		newEquipment = new BaseEquipment();
		newEquipment.ItemName = itemNames[Random.Range (0,3)] + " Item";
		newEquipment.ItemID = Random.Range(1,101);
		ChooseItemType();
		newEquipment.Stamina = Random.Range (1,20);
		newEquipment.Strength = Random.Range (1,20);
		newEquipment.Dexterity = Random.Range (1,20);
		newEquipment.Intellect = Random.Range (1,20);
		newEquipment.Health = Random.Range (1,20);
		newEquipment.Mana = Random.Range (1,20);
		newEquipment.SpellEffectID = Random.Range (1,20);
		return newEquipment;
	
	}

	public void ChooseItemType(){
		int randomTemp = 1;
	//	int randomTemp = Random.Range (1,10);
		if(randomTemp == 1){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		}else if(randomTemp == 2){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BELT;
		}else if(randomTemp == 3){
		newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BRACERS;
		}else if(randomTemp == 4){
		newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		}else if(randomTemp == 5){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHOULDERS;
		}else if(randomTemp == 6){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
		}else if(randomTemp == 7){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
		}else if(randomTemp == 8){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
		}else if(randomTemp == 9){
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.RINGS;
		}

	}
	
}

