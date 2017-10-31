using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBengala : MonoBehaviour {

	public float TransladarBengala;

	void Start () {

	}

	// Update is called once per frame
	void Update () {
		transform.Translate (0, 0, TransladarBengala);
	}
}
