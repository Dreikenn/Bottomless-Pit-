using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBengala : MonoBehaviour {


	public GameObject Bengala;
	public Transform reset;
	public float cadena;
	private float siguiente;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space) && Time.time>siguiente)
		{
			Instantiate (Bengala, reset.position, reset.rotation);
			siguiente = Time.time + cadena;

		}
	}

}
