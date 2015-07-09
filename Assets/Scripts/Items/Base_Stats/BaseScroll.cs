using UnityEngine;
using System.Collections;

public class BaseScroll : BaseStatItem
{
	public ScrollTypes ScrollType { get; set;}

	public enum ScrollTypes{
		HEALTH,
		ENERGY,
		STATS,
		SPECIAL
	}


}

