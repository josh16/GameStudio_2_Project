using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseStatItem : BaseItem {

	//Privvate Variables
	private int strength;
	private int stamina;



	//Getter and setters variables
	public int Strength
	{
		//Grabbing the characters health
		get { return strength; }
		set { strength = value; }
	}

	public int Stamina
	{
		//Grabbing the characters health
		get { return stamina; }
		set { stamina = value; }
	}




}
