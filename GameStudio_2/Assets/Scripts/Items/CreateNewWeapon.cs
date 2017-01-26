using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewWeapon : BaseWeapon {

	private BaseWeapon newWeapon;

	public void Start()
	{
		CreateWeapon();

		Debug.Log(newWeapon.ItemName);
		Debug.Log(newWeapon.ItemDescription);
		Debug.Log(newWeapon.ItemID.ToString());
		Debug.Log(newWeapon.WeaponType.ToString());
		Debug.Log(newWeapon.Stamina.ToString());
	}

	//Create a WeaponTypes function
	public void CreateWeapon()
	{
		//Variables for ID, description,name, and range rumber 
		newWeapon = new BaseWeapon();
		newWeapon.ItemName = "W" + Random.Range (1, 100);
		newWeapon.ItemDescription = "A new Weapon!";
		newWeapon.ItemID = Random.Range (1, 100);

		//Accessing the different types of stats
		newWeapon.Strength = Random.Range (1,11);
		newWeapon.Stamina = Random.Range (1, 11);

		//Calling the choose Weapon function here
		ChooseWeapon ();
	}
		

//Function to choose Weapon
	public void ChooseWeapon()
	{
		//Temp value
		int randomTemp = Random.Range (1, 6);


		//Weapon numbers 
		if (randomTemp == 1) {

			newWeapon.WeaponType = BaseWeapon.WeaponTypes.SWORD;
		} 
		else if (randomTemp == 2) {

			newWeapon.WeaponType = BaseWeapon.WeaponTypes.HAMMER;
		}

		else if (randomTemp == 3) {

			newWeapon.WeaponType = BaseWeapon.WeaponTypes.STAFF;
		}

		else if (randomTemp == 4) {

			newWeapon.WeaponType = BaseWeapon.WeaponTypes.BOW;
		}

		else if (randomTemp == 5) {

			newWeapon.WeaponType = BaseWeapon.WeaponTypes.AXE;
		}



	}


}
