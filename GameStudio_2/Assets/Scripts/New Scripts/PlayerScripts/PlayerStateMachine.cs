using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PlayerStateMachine : MonoBehaviour {

    public BaseHero player;

    //Differemt states for the player
    public enum TurnState {

        PROCESSING,
        ADDTOLIST,
        WAITING,
        SELECTING,
        ACTION,
        DEAD

    }


    //Variables

    public TurnState currentState; //the current state the player is in
    
    public float cur_Cooldown = 0.0f;
    public float max_Cooldown = 5.0f;
    public Image ProgressBar;


    void Start () {

        //Call the processing state when the battle starts
        currentState = TurnState.PROCESSING;


    }






    //Progress bar
    public float cur_coolDown = 0;



	
	// Update is called once per frame
	void Update ()
    {
		switch (currentState)
        {
            case (TurnState.PROCESSING):

                //call update progress bar in this state
                UpgradeProgressBar();

                break;

            case (TurnState.ADDTOLIST):

                break;

            case (TurnState.WAITING):

                break;

            case (TurnState.SELECTING):

                break;

            case (TurnState.ACTION):

                break;

            case (TurnState.DEAD):

                break;
        }


	}

    //
    void UpgradeProgressBar()
    {
        cur_Cooldown = cur_Cooldown + Time.deltaTime;
        float calc_coolDown = cur_Cooldown / max_Cooldown;  // time between current cooldown and max cooldown 
        ProgressBar.transform.localScale = new Vector3(Mathf.Clamp(calc_coolDown,0,1),ProgressBar.transform.localScale.y,ProgressBar.transform.localScale.z);//

        if(cur_Cooldown >=max_Cooldown)
        {
            currentState = TurnState.ADDTOLIST;//

        }



    }

}
