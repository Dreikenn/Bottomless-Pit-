using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morir : MonoBehaviour {

	[SerializeField]

	//Si colisionamos con el enemigo nos mata
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Enemigo") 
		{
			Destroy (this.gameObject);
		}
	}
}