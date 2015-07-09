using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseStatItem
{
	public WeaponTypes WeaponType{get;set;}



	public enum WeaponTypes{
		SWORD,
		STAFF,
		BOW
	}



}

