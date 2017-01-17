 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour {

    private string characterClassName;
    private string characterClassDescription;

    //Stats area
    private int hp;
    private int strength;
    private int stamina;

    //Getters and setters
    public string CharacterClassName
    {
        //Grabbing the characters string name
        get { return characterClassName;}
        set { characterClassName = value;}
    }


    public string CharacterClassDescription
    {
        //Grabbing the characters string name
        get { return characterClassDescription; }
        set { characterClassDescription = value; }
    }

    //Integer values
    public int Hp
    {
        //Grabbing the characters health
        get { return hp;}
        set { hp = value; }
    }

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
