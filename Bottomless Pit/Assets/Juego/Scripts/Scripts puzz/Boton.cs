using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boton : MonoBehaviour {

	private GameObject boton;
	public GameObject Borrar;
	public GameObject Borrar2;
	public GameObject Borrar3;
	void Start () {
		bool boton = false;
	}
	
	void OnTriggerEnter (Collider otro) {
		bool boton = true;
		if (boton == true)
			Destroy(Borrar);
			Destroy(Borrar2);
		Destroy(Borrar3);

	}
}
