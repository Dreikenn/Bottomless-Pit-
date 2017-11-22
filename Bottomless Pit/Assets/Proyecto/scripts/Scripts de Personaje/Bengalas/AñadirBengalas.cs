using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AñadirBengalas : MonoBehaviour {

	[SerializeField]

	public float MasBengalas = 1;

	//Si colisionamos con la bateria se le recarga completamente la misma.
	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") 
		{

			DispararBengala.BengalasMaximas += MasBengalas;

			Destroy (this.gameObject);
		}
	}
}