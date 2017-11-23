using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conseguirvictoria : MonoBehaviour {

	void OnTriggerEnter(Collider otro)
    {
		if (otro.tag == "Player") {
			Application.LoadLevel ("Final");
		}

    }
}
