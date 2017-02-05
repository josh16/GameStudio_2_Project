using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveInfo : MonoBehaviour {




	//function for saving game info
	public static void SaveAllInformation()
	{
		PlayerPrefs.SetInt("PLAYERLEVEL",GameInfo.PlayerLevel); //saves this information to the "PLAYERLEVEL" tag.
		PlayerPrefs.SetString("PLAYERNAME",GameInfo.PlayerName);

		PlayerPrefs.SetInt ("STAMINA", GameInfo.Stamina);
		PlayerPrefs.SetInt ("STRENGTH", GameInfo.Strength);


	}



	







}
