using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarVida : MonoBehaviour {

	[SerializeField]

	private float SumarVida = 1f;

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			Vida.cantidadVida += SumarVida;

			Destroy (this.gameObject);
		}
	}
}
