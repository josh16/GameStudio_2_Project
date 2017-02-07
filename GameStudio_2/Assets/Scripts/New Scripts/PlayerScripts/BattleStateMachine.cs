using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateMachine : MonoBehaviour {

	public enum PerformAction //different actions for battling
    {
        WAIT,
        TAKEACTION,
        PERFORMACTION, //DOES THE ACTING
    }

    //Reference to the enum
    public PerformAction battleStates;

   //Lists
    public List<HandleTurns> PerformList = new List<HandleTurns>();// lists will only store handleTurns

    public List<GameObject> HeroesInBattle = new List<GameObject>(); //
    public List<GameObject> EnemysInBattle = new List<GameObject>(); //


// Use this for initialization
    void Start () {
        battleStates = PerformAction.WAIT;
        EnemysInBattle.AddRange(GameObject.FindGameObjectsWithTag("Enemy"));//Checks how many enemies are in the game
        HeroesInBattle.AddRange(GameObject.FindGameObjectsWithTag("Player"));//Checks how many enemies are in the game


    }
	
	// Update is called once per frame
	void Update () {
		
        switch(battleStates)
        {
            case (PerformAction.WAIT):

                if(PerformList.Count>0)
                {
                    battleStates = PerformAction.TAKEACTION;
                }
                break;

            case (PerformAction.TAKEACTION):


                break;

            case (PerformAction.PERFORMACTION):


                break;

        }

	}


    public void CollectActions(HandleTurns input)//collecting actions
    {
        PerformList.Add(input);

    }

}
