using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BaseHero  {

    public string name;

    public float baseHp;
    public float curHP;

    public float baseMp;
    public float curMp;

    public int stamina;
    public int intellect;
    public int dexterity;
    public int agility; //avoiding enemies
}
