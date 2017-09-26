using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour 
{
 static public float cantidadVida;

	void Update()
	{
		if(cantidadVida <= 0)
		{

			Application.LoadLevel("Muerto");
		}
	}
}