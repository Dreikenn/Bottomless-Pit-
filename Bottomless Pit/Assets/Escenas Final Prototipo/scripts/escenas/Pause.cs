using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public bool pausado;
	public GameObject Pantalla;
	// Use this for initialization
	void Start () 
	{
		Pantalla.SetActive (false);
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (pausado == false) {
				pausado = true;
				Pantalla.SetActive (true);
				Time.timeScale = 0;
			}
			else 
			{
				pausado = false;
				Pantalla.SetActive (false);
				Time.timeScale = 1;
			}
		}

	}
}
