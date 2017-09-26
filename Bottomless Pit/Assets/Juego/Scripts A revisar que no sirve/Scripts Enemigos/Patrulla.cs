using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//importante para el nav
using UnityEngine.AI;

public class Patrulla : MonoBehaviour {

	private int posicion;
	private NavMeshAgent nma;

	public Transform[] Lugares;

	void Awake()
	{
		nma = GetComponent<NavMeshAgent> ();
		nma.destination = Lugares[posicion].position;
	}

	void Update()
	{
		if (!nma.pathPending && nma.remainingDistance <= nma.stoppingDistance) 
		{

			posicion++;
			posicion %= Lugares.Length;
			nma.destination = Lugares[posicion].position;
		}
	}


}
