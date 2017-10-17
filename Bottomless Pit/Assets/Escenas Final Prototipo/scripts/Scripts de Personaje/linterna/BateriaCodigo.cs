using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BateriaCodigo : MonoBehaviour {

	[SerializeField]

	private float BateriaCargada;

	//Si colisionamos con la bateria se le recarga completamente la misma.
	void OnTriggerEnter(Collider other) 
	{
		BateriaCargada = 0.3f;
		if (other.tag == "Player") 
		{
			
			LinternaCodigo.bateria += BateriaCargada;
		
			Destroy (this.gameObject);
		}
	}
}
