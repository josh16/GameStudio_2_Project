using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testGUI : MonoBehaviour {

    private BaseClass class1 = new BaseGoblinClass();
    private BaseClass class2 = new BaseWarriorClass();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnGUI(){
        //Character class 1
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Hp.ToString());
        GUILayout.Label(class1.Stamina.ToString());
        GUILayout.Label(class1.Strength.ToString());
       
        //Character class 2
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Hp.ToString());
        GUILayout.Label(class2.Stamina.ToString());
        GUILayout.Label(class2.Strength.ToString());


    }


}
