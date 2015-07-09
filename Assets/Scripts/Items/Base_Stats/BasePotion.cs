using UnityEngine;
using System.Collections;

public class BasePotion : BaseStatItem
{
	public PotionTypes PotionType{ get; set;}

	public enum PotionTypes{
		HEALTH,
		ENERGY,
		STATS,
		SPECIAL
	}

}

