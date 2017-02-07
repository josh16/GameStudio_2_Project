using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyStateMachine : MonoBehaviour {

    private BattleStateMachine BSM; // reference to the other script
    public BaseEnemy enemy; //inherits from BaseEnemy Script

    //Differemt states for the Enemy
    public enum TurnState
    {

        PROCESSING,
        CHOOSEACTION,
        WAITING,
        ACTION,
        DEAD

    }


    //Variables

    public TurnState currentState; //the current state the player is in

    public float cur_Cooldown = 0.0f;
    public float max_Cooldown = 5.0f;
    public Image ProgressBar;
    //For animations later
    private Vector3 startPos;

    // time for action variables
    private bool actionStarted = false; // Bool to check if the action started

    private GameObject HeroToAttack; // reference to the Hero(Player)
    private float animSpeed = 5.0f;



    // Use this for initialization
    void Start () {
        currentState = TurnState.PROCESSING;
        BSM = GameObject.Find("BattleManager").GetComponent<BattleStateMachine>();//Connection to battleStateMachine Script
        startPos = transform.position; 
    }
	
	// Update is called once per frame
	void Update () {

        switch (currentState)
        {
            case (TurnState.PROCESSING):


                break;
                
            case (TurnState.CHOOSEACTION):
                //Call chooseAction function
                ChooseAction(); //We are only going to do this action once
                currentState = TurnState.WAITING;

                break;
                
            case (TurnState.WAITING):
                //this will be the idle state
                break;

            case (TurnState.ACTION):

                StartCoroutine(TimeForAction());

                break;

            case (TurnState.DEAD):

                break;
        }
    }

    void UpgradeProgressBar()
    {
        cur_Cooldown = cur_Cooldown + Time.deltaTime;
        float calc_coolDown = cur_Cooldown / max_Cooldown;  // time between current cooldown and max cooldown 
       // ProgressBar.transform.localScale = new Vector3(Mathf.Clamp(calc_coolDown, 0, 1), ProgressBar.transform.localScale.y, ProgressBar.transform.localScale.z);//

        if (cur_Cooldown >= max_Cooldown)
        {
            currentState = TurnState.CHOOSEACTION;//

        }
    }


    void ChooseAction()
    {
        HandleTurns myAttack = new HandleTurns();//populated the attack
        myAttack.Attacker = enemy.name; // enemies name stored into the attack
        myAttack.AttackersGameObject = this.gameObject; // This game object will be the attackers target
        myAttack.AttackersTarget = BSM.HeroesInBattle[Random.Range(0, BSM.HeroesInBattle.Count)];//targets any hero(Player)
        BSM.CollectActions(myAttack);
    }


private IEnumerator TimeForAction()
    {

        if(actionStarted)
        {
            yield break;
        }

        actionStarted = true;

        //Animate the hero to attack
        Vector3 heroPos = new Vector3(HeroToAttack.transform.position.x - 1.5f, HeroToAttack.transform.position.y , HeroToAttack.transform.position.z );
        while(MoveTowardsEnemy(heroPos)){ yield return null;}

        //wait a few seconds...

        //Do damage at that point

        //animate back to start position

        //remove this performer from the battle State machine (Want the attack to happen once)

        //Reset the Battle State machine -> wait

        actionStarted = false;


        //Reset the enemys state
        cur_Cooldown = 0.0f;
        currentState = TurnState.PROCESSING;


    }

    //move towards the player
    private bool MoveTowardsEnemy(Vector3 target)
    {
        return target != (transform.position = Vector3.MoveTowards(transform.position,target, animSpeed * Time.deltaTime));
    }

}
