using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfo : MonoBehaviour {



	void Awake()
	{
		
		DontDestroyOnLoad(transform.gameObject);

	}

	public static string PlayerName{ get; set; }
	public static int PlayerLevel{ get; set; }
	public static BaseClass PlayerClass{ get; set; }
	public static int Stamina{ get; set; }
	public static int Strength{ get; set; }






	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
