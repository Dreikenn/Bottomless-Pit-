using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contraseña : MonoBehaviour {
	
	public string curPassword = "9324";
	public string input;
	public bool onTrigger;
	public bool keypadScreen;
	public GameObject prefab;
    

    

    void OnTriggerEnter(Collider other) 
	{
        if (other.tag == "Player")
        {

            onTrigger = true;
        }      
    }
	void OnTriggerExit(Collider other) {


		keypadScreen = false;
		onTrigger = false;
		input = "";
        
    }
	void Update()
	{
		if (input == curPassword)
		{
			Destroy (prefab);
		}
	}
	void OnGUI()
	{
		if (onTrigger)
		{
			GUI.Box(new Rect(250,250,200,25), "Tocar 'X' para abrir panel");

			if(Input.GetKeyDown(KeyCode.X))
			{
				keypadScreen = true;
				onTrigger = false;

			}
		}


		if (keypadScreen)
		{
			
			GUI.Box (new Rect (265, 120, 150, 25), input);
			if(GUI.Button (new Rect (265, 145, 50, 50), "1"))
			{
		
				input = input + "1";
			}
			if(GUI.Button (new Rect (315, 145, 50, 50), "2"))
			{
				
				input = input + "2";
			}
			if(GUI.Button (new Rect (365, 145, 50, 50), "3"))
			{
				
				input = input + "3";
			}if(GUI.Button (new Rect (265, 195,50, 50), "4"))
			{
				
				input = input + "4";
			}
			if(GUI.Button (new Rect (315, 195,50, 50), "5"))
			{
				
				input = input + "5";
			}
			if(GUI.Button (new Rect (365, 195, 50, 50), "6"))
			{
				
				input = input + "6";
			}if(GUI.Button (new Rect (265, 245, 50, 50), "7"))
			{
				
				input = input + "7";
			}
			if(GUI.Button (new Rect (315, 245,50, 50), "8"))
			{
				
				input = input + "8";
			}
			if(GUI.Button (new Rect (365, 245, 50, 50), "9"))
			{
				
				input = input + "9";
			}

	}
	}}
