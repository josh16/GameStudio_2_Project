using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BaseEnemy  {

    public string name;


    //ENUMERATOR OF ELEMENTS
    public enum Type
    {
        FIRE,
        WATER,
        WIND,
        EARTH

    }

    //item drops
    public enum Rarity
    {
        COMMON,
        UNCOMMON,
        RARE,
        LEGENDARY

    }

    public Type enemyType;
    public Rarity rarity;



    //health/MP variables
    public float baseHp;
    public float curHP;

    public float baseMp;
    public float curMp;

    //Attack/defense
    public float baseATK;
    public float curATK; // for upgrades later
    public float baseDEF;
    public float curDEF;





}
