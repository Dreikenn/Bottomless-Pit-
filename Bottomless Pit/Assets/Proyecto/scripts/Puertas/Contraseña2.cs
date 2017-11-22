using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contraseña2 : MonoBehaviour {

	public string curPassword;
	public string input;
	public bool onTrigger;
	public bool keypadScreen;
	public GameObject prefab;

[SerializeField] 
	public Texture Imagen1;
[SerializeField] 
	public Texture Imagen2;
[SerializeField] 
	public Texture Imagen3;
[SerializeField] 
	public Texture Imagen4;
[SerializeField] 
	public Texture Imagen5;
[SerializeField] 
	public Texture Imagen6;
[SerializeField] 
	public Image Tocar;

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
			/*
			Imagen1.enabled = true;	
			Imagen2.enabled = true;
			Imagen3.enabled = true;
			Imagen4.enabled = true;
			Imagen5.enabled = true;
			Imagen6.enabled = true;*/
		}
	}


	if (keypadScreen)
	{


		if(GUI.Button (new Rect (225, 145, 50, 50), " "))
		{

			input = input + "9";
		}
		if(GUI.Button (new Rect (315, 145, 50, 50), " "))
		{

			input = input + "5";
		}
		if(GUI.Button (new Rect (405, 145, 50, 50), " "))
		{

			input = input + "3";
		}
		if(GUI.Button (new Rect (225, 195, 50, 50), " "))
		{

				input = input + "6";
		}
		if(GUI.Button (new Rect (315, 195, 50, 50), " "))
		{

				input = input + "8";
		}
		if(GUI.Button (new Rect (405, 195, 50, 50), " "))
		{

				input = input + "4";
		}

	}
}}
