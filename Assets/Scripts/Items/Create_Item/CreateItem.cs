using UnityEngine;
using System.Collections;

public class CreateItem
{
	public int ItemSelection{get;set;}
	public BaseEquipment anEquipment = new BaseEquipment();
	public BaseWeapon aWeapon = new BaseWeapon();
	public BaseScroll aScroll = new BaseScroll();
	public BasePotion aPotion = new BasePotion();
	public CreateNewEquipment newEquipment = new CreateNewEquipment();
	public CreateNewWeapon newWeapon = new CreateNewWeapon();
	public CreateNewPotion newPotion = new CreateNewPotion();
	public CreateNewScroll newScroll = new CreateNewScroll();



	public void CreateAItem(int ItemSelection){
		if (ItemSelection == 1){
			anEquipment = newEquipment.CreateEquipment();
		} else if (ItemSelection == 2){
			aWeapon =newWeapon.CreateWeapon();
		} else if (ItemSelection == 3){
			aPotion =newPotion.CreatePotion();
		} else if (ItemSelection == 4){
			aScroll =	newScroll.CreateScroll();
		} 
		
		
	}
}

