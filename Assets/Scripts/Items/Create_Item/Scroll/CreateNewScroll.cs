using UnityEngine;
using System.Collections;

public class CreateNewScroll : MonoBehaviour
{
	public BaseScroll newScroll;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	public BaseScroll CreateScroll() {
		newScroll = new BaseScroll();
		newScroll.ItemName = "Scroll";
		newScroll.ItemDescription = "This is a Scroll.";
		newScroll.ItemID = Random.Range(1,101);
		ChooseScrollType();
		return newScroll;
	}
	
	public void ChooseScrollType(){
		switch (Random.Range(1,5))
		{
		case 4:
			newScroll.ScrollType = BaseScroll.ScrollTypes.ENERGY;
			break;
		case 3:
			newScroll.ScrollType = BaseScroll.ScrollTypes.HEALTH;
			break;
		case 2:
			newScroll.ScrollType = BaseScroll.ScrollTypes.STATS;
			break;
		case 1:
			newScroll.ScrollType = BaseScroll.ScrollTypes.SPECIAL;
			break;
		}
	}
	
}
