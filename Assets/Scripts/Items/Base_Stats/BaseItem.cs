using UnityEngine;
using System.Collections;

public class BaseItem : MonoBehaviour {
	public string ItemName{get;set;}
	public string ItemDescription{get;set;}

	public int ItemID{get;set;}
	public int Durability{get;set;}

	public ItemTypes ItemType{get;set;}



	public enum ItemTypes{
		EQUIPMENT,
		WEAPON,
		SCROLL,
		POTION,
	}



}
