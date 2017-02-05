using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInfo {




	//Load info function
	public static void LoadAllInformation()
	{	
		GameInfo.PlayerName = PlayerPrefs.GetString ("PLAYERNAME");//this will return any information that is under this tag name
		GameInfo.PlayerLevel = PlayerPrefs.GetInt ("STAMINA");
		GameInfo.PlayerLevel = PlayerPrefs.GetInt ("PLAYERLEVEL");
		GameInfo.PlayerLevel = PlayerPrefs.GetInt ("STRENGTH");





	}












}
