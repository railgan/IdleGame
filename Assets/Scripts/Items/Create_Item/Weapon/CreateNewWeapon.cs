using UnityEngine;
using System.Collections;

public class CreateNewWeapon : MonoBehaviour
{
	public BaseWeapon newWeapon;
	private int randomTemp;

	public BaseWeapon CreateWeapon() {

		newWeapon =  new BaseWeapon();

		//assign name to the weapon
		newWeapon.ItemName = "W" + Random.Range (1,101);

		//create a weapon descriptuion
		newWeapon.ItemDescription = "This is a random new Weapon";

		//weapon id
		newWeapon.ItemID = Random.Range(1,101);

		//stats
		newWeapon.Stamina = Random.Range (1,20);
		newWeapon.Strength = Random.Range (1,20);
		newWeapon.Dexterity = Random.Range (1,20);
		newWeapon.Intellect = Random.Range (1,20);
		newWeapon.Health = Random.Range (1,20);
		newWeapon.Mana = Random.Range (1,20);
		newWeapon.SpellEffectID = Random.Range (1,20);

		//weaponType
		ChooseWeaponType();

		//spellEffectID
		newWeapon.SpellEffectID = Random.Range (1,20);

	
		return newWeapon;
	
	
	
	
	}
	private void ChooseWeaponType(){
		randomTemp = Random.Range (1,4);
			if(randomTemp == 1){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		}else if(randomTemp == 2){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}else if(randomTemp == 3){
			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}
	}
	// Use this for initialization
	void Start ()
	{
		CreateWeapon();
		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemID.ToString());
		Debug.Log(newWeapon.ItemDescription.ToString());
		Debug.Log(newWeapon.WeaponType);

		
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

