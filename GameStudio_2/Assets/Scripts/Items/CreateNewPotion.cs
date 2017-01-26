using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewPotion : MonoBehaviour {

	//Declared Variables
	private BasePotion newPotion;


	void Start()
	{
		CreatePotion();

		Debug.Log(newPotion.ItemName);
		Debug.Log(newPotion.ItemDescription);
		Debug.Log(newPotion.ItemID.ToString());
		Debug.Log(newPotion.PotionType.ToString());

		ChoosePotionType ();
	}


	public void CreatePotion()
	{
		newPotion = new BasePotion(); // Creating potion which is dervied from the BasePotion class.
		newPotion.ItemName = "potion";
		newPotion.ItemDescription = "A basic potion";
		newPotion.ItemID = Random.Range(0,101);


	}


	//Choosing a type of potion
	private void ChoosePotionType()
	{
		int randomTemp = Random.Range (1, 4);

		if (randomTemp == 1) 
		{
			newPotion.PotionType = BasePotion.PotionTypes.HEALTH;
		} 
		else if (randomTemp == 2) 
		{
			newPotion.PotionType = BasePotion.PotionTypes.MAGIC;
		}

		else if (randomTemp == 3) 
		{
			newPotion.PotionType = BasePotion.PotionTypes.SPEED;
		}

		else if (randomTemp == 4) 
		{
			newPotion.PotionType = BasePotion.PotionTypes.STRENGTH;
		}






	}


}
