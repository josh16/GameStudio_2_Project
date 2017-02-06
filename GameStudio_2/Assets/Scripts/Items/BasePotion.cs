using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePotion : BaseItem { // <-- Base potion is derived from BasePotion Class

	//Variables for Potion
	public enum PotionTypes{
		HEALTH,
		MAGIC,
		STRENGTH,
		SPEED,

		//Leave this open if you want to add more after
	}

	//Public Setters and Getters
	private PotionTypes potionType;

		
	public PotionTypes PotionType {

		get { return potionType; }
		set { potionType = value; }

	}


}
