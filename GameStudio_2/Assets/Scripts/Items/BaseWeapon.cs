using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : BaseStatItem { // This is inheriting from BaseStatItem <- BaseItem 


	//Enumerator for different weapon types
	public enum WeaponTypes
	{
		SWORD,
		HAMMER,
		STAFF,
		BOW,
		AXE
		//Leave extra room here if you want to add extra weapons for the future

	}

	private WeaponTypes weaponType;


	public WeaponTypes WeaponType
	{
		get { return weaponType ; }
		set { weaponType = value; }
	}


}
