using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnBasedCombatBased : MonoBehaviour {

	//Different Game States
	public enum BattleStates
	{
		START,
		PLAYERCHOICE,
		ENEMYCHOICE,
		LOSE,
		WIN,
		EXPERIENCE

	}


	//Set the Enumerator to a variable thats called current states.
	private BattleStates currentState;



	void Start()
	{
		currentState = BattleStates.START; //Setting the start State first
	}



	void Update()
	{
		//Switch statements for what the current state will be.
		//These will be placed in the update
		switch (currentState) {

		case (BattleStates.START):
			//function will go here

			break;
		
		case (BattleStates.PLAYERCHOICE):

			//function will go here

			break;

		case (BattleStates.ENEMYCHOICE):

			//function will go here

			break;

		case (BattleStates.EXPERIENCE):

			//function will go here

			break;
		

		case (BattleStates.LOSE):

			//function will go here

			break;
		
		case (BattleStates.WIN):

			//function will go here

			break;
		}

	}




	//On screen button to switch to different game states 
	void onGUI(){
		//The logic will be place here


	}



}
