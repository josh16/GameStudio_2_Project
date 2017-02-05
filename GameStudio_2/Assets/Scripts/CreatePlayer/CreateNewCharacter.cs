using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewCharacter : MonoBehaviour {



	//Declared variables
	private BasePlayer newPlayer;
	private string playerName = "Enter Name :";

	//Toggles for selecting which class to choose from
	private bool isGoblinClass;
	private bool isWarriorClass;


	void Start()
	{
		//calls and sets up the new baseplayer
		newPlayer = new BasePlayer();
	}



	void Update()
	{


	}


	//UI 
	void OnGUI()
	{
		playerName = GUILayout.TextArea (playerName,15); //Max it out as 15 characters for name
		isGoblinClass = GUILayout.Toggle (isGoblinClass, "Goblin Class");
		isWarriorClass = GUILayout.Toggle (isWarriorClass, "Warrior Class");

		//Create the button
		if (GUILayout.Button ("Create")) {
			if(isWarriorClass)
			{
				newPlayer.PlayerClass = new BaseWarriorClass();
			}
			else if(isGoblinClass)
			{
				newPlayer.PlayerClass = new BaseGoblinClass();
			}

			//Setting the players Level (Starts at 1 of course)
			newPlayer.PlayerLevel = 1;
			newPlayer.PlayerName = playerName;//Creating the player name.
			newPlayer.Stamina = newPlayer.PlayerClass.Stamina;
			newPlayer.Strength = newPlayer.PlayerClass.Strength;
			//Call the save info script to save All information above.
			SaveInfo.SaveAllInformation ();



			Debug.Log ("PlayerClass " + newPlayer.PlayerClass.CharacterClassName);
		}
			
				


	}



}
