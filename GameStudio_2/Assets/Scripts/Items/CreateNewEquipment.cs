using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewEquipment : MonoBehaviour {

	//Created new variables
	private BaseEquipment newEquipment;
	private string[] itemNames = new string[4]{"Common","Great","Amazing","Insane"};
	private string[] itemDesc = new string[]{"Type: Water", "Type: Fire", "Type: Earth"};

	void Start()
	{
		CreateEquipment();
		Debug.Log(newEquipment.ItemName);
		Debug.Log(newEquipment.ItemDescription);
		Debug.Log(newEquipment.ItemID.ToString());
		Debug.Log (newEquipment.EquipmentType.ToString());
		Debug.Log(newEquipment.Stamina.ToString());
	}

	void Update()
	{


	}

	//Create Equipment function
	public void CreateEquipment()
	{
		newEquipment = new BaseEquipment();// Creating a new base equipment here
		newEquipment.ItemID = Random.Range (1, 101); // ID number from 1 to 101.
		newEquipment.ItemName = itemNames[Random.Range(0,3)] + " Item";
		newEquipment.ItemDescription = itemDesc [Random.Range (0, itemDesc.Length)]; // This will choose a random desciption inside the itemDesc array. 
		//Calling the Choose Item function to create
		ChooseItemType();
		newEquipment.Strength = Random.Range (1,11);
		newEquipment.Stamina = Random.Range (1, 11);
	}


	//The different types of items
	private void ChooseItemType()
	{
		//variable declaration here
		int randomTemp = Random.Range (1, 8);

		//Different types of equipments
		if (randomTemp == 1) 
		{
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
		} 
		else if (randomTemp == 2) 
		{
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
		
		}

		else if (randomTemp == 3) 
		{
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGGINGS;

		}
	
		else if (randomTemp == 4) 
		{
			newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.SHIELD;

		}
	
	
	}


}
