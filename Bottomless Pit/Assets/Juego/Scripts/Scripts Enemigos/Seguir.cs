using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seguir : MonoBehaviour
{

	public Transform target;
	public float Velocidad;
	public float Largo;
	// Use this for initialization
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		//Normalizar//

		Vector3 diff = target.position - transform.position;
		Vector3 dir = diff.normalized;
		float Distancia = diff.magnitude;
		Vector3 mov = dir * Velocidad * Time.deltaTime;
		mov = Vector3.ClampMagnitude(mov, Distancia);
		transform.position += mov;

		if (Distancia > Largo)
		{
			transform.position += mov;
		}
		else
		{
			transform.position -= mov;
		}




	}

}