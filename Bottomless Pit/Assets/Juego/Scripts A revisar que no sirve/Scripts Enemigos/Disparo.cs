using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour {
	public GameObject prefab;
	public float retrasoInicial;
	public float retrasoDisparos;

	void Awake()
	{
		InvokeRepeating ("Disparar", retrasoInicial, retrasoDisparos);
	}

	void Disparar()
	{
		Instantiate(prefab, transform.position, transform.rotation);
	}
}
