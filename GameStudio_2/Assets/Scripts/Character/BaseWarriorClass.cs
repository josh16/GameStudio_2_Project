using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Inheriting from the BaseClass script, not monobehaviour
public class BaseWarriorClass : BaseClass {

	
    public BaseWarriorClass()
    {
        CharacterClassName = "Warrior";
        CharacterClassDescription = "A Strong powerful Warrior!!";

        Stamina = 10;
        Hp = 80;
        Strength = 15;

    }


}
