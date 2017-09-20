using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour {

	void OnTriggerEnter (Collider otro) 
	{
		Application.LoadLevel("Ganar");

	}
}
