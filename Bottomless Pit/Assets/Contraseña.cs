using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contraseña : MonoBehaviour {
	
	public string curPassword;
	public string input;
	public bool onTrigger;
	public bool keypadScreen;
	public GameObject prefab;

	[SerializeField] 
	private Image Imagen1;
	[SerializeField] 
	private Image Imagen2;
	[SerializeField] 
	private Image Imagen3;
	[SerializeField] 
	private Image Tocar;

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

			Imagen1.enabled = false;	
			Imagen2.enabled = false;
			Imagen3.enabled = false;
		Tocar.enabled = false;	
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
			
			Tocar.enabled = true;	
			if(Input.GetKeyDown(KeyCode.X))
			{
				Tocar.enabled = false;
				keypadScreen = true;
				onTrigger = false;
				Imagen1.enabled = true;	
				Imagen2.enabled = true;
				Imagen3.enabled = true;
			}
		}


		if (keypadScreen)
		{
			

			if(GUI.Button (new Rect (225, 145, 50, 50), " "))
			{
				
				input = input + "1";
			}
			if(GUI.Button (new Rect (315, 145, 50, 50), " "))
			{
				
				input = input + "2";
			}
			if(GUI.Button (new Rect (405, 145, 50, 50), " "))
			{
				
				input = input + "3";
			}

	}
	}}
