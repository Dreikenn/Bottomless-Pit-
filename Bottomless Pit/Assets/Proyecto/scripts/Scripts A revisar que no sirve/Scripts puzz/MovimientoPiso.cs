using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPiso : MonoBehaviour {

	public Transform movimientoplataforma;
	public Transform posicion1;
	public Transform posicion2;
	public Vector3 NuevaPosicion;
	public string PosicionActual;
	public float smooth;
	public float reset;

	void Start () {
		CambiarObjetivo ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		movimientoplataforma.position = Vector3.Lerp (movimientoplataforma.position, NuevaPosicion, smooth * Time.deltaTime);
	}

	void CambiarObjetivo(){
		if (PosicionActual == "posicion1")
		{
			PosicionActual = "posicion2";
			NuevaPosicion = posicion2.position;
		}else if(PosicionActual == "posicion2"){
			PosicionActual = "posicion1";
			NuevaPosicion = posicion1.position;
		}else if(PosicionActual == ""){
			PosicionActual = "posicion2";
			NuevaPosicion = posicion2.position;
		}
		Invoke ("CambiarObjetivo", reset);
	}	}
