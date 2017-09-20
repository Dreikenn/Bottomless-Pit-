using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour 
{
 public float cantidadVida;

	void Update()
	{
		if(cantidadVida <= 0)
		{
			Destroy (gameObject);
		}
	}
}