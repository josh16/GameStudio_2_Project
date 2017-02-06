using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseItem : MonoBehaviour {

	//Item variables
	private string itemName;
	private string itemDescription;
	private int itemID;

	public enum ItemTypes{
		EQUIPMENT,
		POTIONS,
		CHEST,
		WEAPON
		///LEAVE ROOM IF YOU WANT TO ADD MORE ITEMS

	}

	private ItemTypes itemType;


	//Getters and Setters
	public string ItemName
	{
		get{return itemName;}
		set{ itemName = value;}
	}


	public string ItemDescription
	{
		get{return itemDescription;}
		set{ itemDescription = value;}
	}

	public int ItemID
	{
		get{return itemID;}
		set{ itemID = value;}
	}


	public ItemTypes ItemType
	{
		get{return itemType;}
		set{ itemType = value;}
	}

}
