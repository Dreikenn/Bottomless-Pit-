using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraEnergia : MonoBehaviour {
 public float EnergiaMaxima = 100f;
 public float EnergiaActual = 0f;
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
			InvokeRepeating ("Decrecer", 1f, 1f);
		}
		
	}

	void Decrecer()
	{
		EnergiaActual -=10f;
		float CalcularEnergia = EnergiaActual / EnergiaMaxima;

		ManejarLaBarra (CalcularEnergia);
	}

	public void ManejarLaBarra(float BarraActual)
	{
		Barra.transform.localScale = new Vector3 (BarraActual, Barra.transform.localScale.y, Barra.transform.localScale.z);
	}
}
