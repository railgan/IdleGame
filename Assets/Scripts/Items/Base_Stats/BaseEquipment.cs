using UnityEngine;
using System.Collections;
[System.Serializable]
public class BaseEquipment : BaseStatItem
{

	public EquipmentTypes EquipmentType{get;set;}

	public enum EquipmentTypes{
		HEAD,
		CHEST,
		SHOULDERS,
		BRACERS,
		LEGS,
		FEET,
		RINGS,
		HANDS,
		BELT
	}
	
	

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

