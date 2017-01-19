using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGoblinClass : BaseClass
{


    public  BaseGoblinClass()
    {
        CharacterClassName = "Goblin";
        CharacterClassDescription = "A powerful filthy Orc thing";

        Stamina = 8;
        Hp = 100;
        Strength = 10;

    }

}