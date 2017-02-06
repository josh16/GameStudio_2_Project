using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer{


	private string playerName;
	private int playerLevel;
	private BaseClass playerClass;//Derived from baseclass script

	private int stamina;
	private int strength;
	private int endurance;



	//Getters and setters for the variables
	/*
	public string PlayerName
	{
		get{return playerName;}
		set{ playerName = value;}

	}
	*/

	public string PlayerName{ get; set;}



	public int PlayerLevel
	{
		get{return playerLevel;}
		set{ playerLevel = value;}

	}

	public BaseClass PlayerClass
	{
		get{return playerClass;}
		set{playerClass = value;}
	}


	public int Stamina
	{
		get{return stamina;}
		set{ stamina = value;}

	}

	public int Strength
	{
		get{return strength;}
		set{ strength = value;}

	}


	public int Endurance
 	{
		get{return endurance;}
		set{ endurance = value;}

	}


}
