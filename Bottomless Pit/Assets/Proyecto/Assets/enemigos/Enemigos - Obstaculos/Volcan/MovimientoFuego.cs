using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoFuego : MonoBehaviour {

	public float MovBala;

	void Update()
	{  
		transform.Translate (0, MovBala, 0);
	}
	void OnTriggerEnter(){

		Destroy(gameObject);
	}
}
