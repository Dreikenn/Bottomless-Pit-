using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contraseña : MonoBehaviour {
	
	public string curPassword = "9324";
	public string input;
	public bool onTrigger;
	public bool keypadScreen;
	public GameObject prefab;


	void OntriggerEnter (Collider other) 
	{
				onTrigger = true;
	}
	void OntriggerExit (Collider other) {

		onTrigger = false;
		keypadScreen = false;
		input = "";
	}
	void Update()
	{
		if (input == curPassword)
		{
			Destroy (prefab);
		}
	}
	void onGui () {
		if (onTrigger)
		{
			GUI.Box(new Rect(6,50,200,25), "Tocar 'X' para habrir panel");
			if(Input.GetKeyDown(KeyCode.X))
			{
				keypadScreen = true;
				onTrigger = false;
			}
		}


		if (keypadScreen)
		{
			GUI.Box (new Rect (0, 0, 400, 400), "");
			GUI.Box (new Rect (5, 5, 310, 25), input);
			if(GUI.Button (new Rect (5, 35, 100, 100), "1"))
			{
		
				input = input + "1";
			}
			if(GUI.Button (new Rect (110, 35, 100, 100), "2"))
			{
				
				input = input + "2";
			}
			if(GUI.Button (new Rect (215, 35, 100, 100), "3"))
			{
				
				input = input + "3";
			}if(GUI.Button (new Rect (5, 140, 100, 100), "4"))
			{
				
				input = input + "4";
			}
			if(GUI.Button (new Rect (110, 140, 100, 100), "5"))
			{
				
				input = input + "5";
			}
			if(GUI.Button (new Rect (215, 140, 100, 100), "6"))
			{
				
				input = input + "6";
			}if(GUI.Button (new Rect (5, 240, 100, 100), "7"))
			{
				
				input = input + "7";
			}
			if(GUI.Button (new Rect (110, 240, 100, 100), "8"))
			{
				
				input = input + "8";
			}
			if(GUI.Button (new Rect (215, 240, 100, 100), "9"))
			{
				
				input = input + "9";
			}

	}
	}}
