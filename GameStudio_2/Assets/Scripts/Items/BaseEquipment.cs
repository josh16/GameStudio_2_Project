using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEquipment : BaseStatItem{

	//Enumerator for the different types of weapons
	public enum EquipmentTypes{
		HEAD,
		CHEST,
		LEGGINGS,
		SHIELD

	}


	private EquipmentTypes equipmentType; // Pass this reference to the getter and setter function

	//Setters and Getters
	public EquipmentTypes EquipmentType {

		get { return equipmentType; }
		set { equipmentType = value; }

	}

}
