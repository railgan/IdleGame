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



	public BaseItem CreateAItem(int ItemSelection){
		if (ItemSelection == 1) {
			anEquipment = newEquipment.CreateEquipment ();
			return anEquipment;
		} else if (ItemSelection == 2) {
			aWeapon = newWeapon.CreateWeapon ();
			return aWeapon;
		} else if (ItemSelection == 3) {
			aPotion = newPotion.CreatePotion ();
			return aPotion;
		} else if (ItemSelection == 4) {
			aScroll = newScroll.CreateScroll ();
			return aScroll;
		} else {
			anEquipment = newEquipment.CreateEquipment ();
			return anEquipment;
		}
		
	}
	public BaseEquipment CreateEquipment(){
		anEquipment = newEquipment.CreateEquipment ();
		return anEquipment;
	}
}

