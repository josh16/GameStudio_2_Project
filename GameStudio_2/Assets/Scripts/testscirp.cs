using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testscirp : MonoBehaviour {

	void Start()
    {
        LoadInfo.LoadAllInformation();
        Debug.Log("Player name: " + GameInfo.PlayerName);


    }


}
