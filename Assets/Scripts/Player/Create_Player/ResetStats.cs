using UnityEngine;
using System.Collections;

public class ResetStats : MonoBehaviour
{
	public static void ResetLevel(){
		GameInformation.PlayerLevel = 0;
		GameInformation.RequiredXP = 0;
		GameInformation.CurrentXP = 0;
		SaveInformation.SaveAllInformation();

	}

}
