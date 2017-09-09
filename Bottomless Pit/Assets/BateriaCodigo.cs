using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateriaCodigo : MonoBehaviour {

	[SerializeField]

	private float BateriaCargada = 20f;

	//Si colisionamos con la bateria se le recarga completamente la misma.
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{
			LinternaCodigo.bateria += BateriaCargada;

			Destroy (this.gameObject);
		}
	}
}
