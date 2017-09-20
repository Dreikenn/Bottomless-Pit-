using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pasos : MonoBehaviour {

	public AudioSource Pasos;
	void Start () {
		
	}
	
	// Codigo para los pies
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Tierra")
		{
			Pasos.Play();
		}
	}}
