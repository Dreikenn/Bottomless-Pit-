using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraEnergia : MonoBehaviour {
 public float EnergiaMaxima;
 public float EnergiaActual;
 public GameObject Barra;

	// Use this for initialization
	void Start ()
	{
		EnergiaActual = EnergiaMaxima;

	}
	
	// Update is called once per frame
	void Update ()
	{ 
		if (Input.GetKeyDown ("e"))
		{
			Decrecer ();
		}
			
		
	}

	void Decrecer()
	{
		EnergiaActual -= 5;
		Barra.transform.localScale = new Vector3((EnergiaActual/EnergiaMaxima),1,1);
	}

}
