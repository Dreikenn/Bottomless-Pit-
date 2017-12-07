using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkfalso : MonoBehaviour {
	public GameObject tp;



	public void OnTriggerEnter(Collider hit)
	{

		hit.transform.position = tp.transform.position;


	}
}
