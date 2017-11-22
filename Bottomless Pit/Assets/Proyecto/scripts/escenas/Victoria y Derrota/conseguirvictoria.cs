using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conseguirvictoria : MonoBehaviour {

    void OnTriggerEnter(Collider otro)
    {
        Application.LoadLevel("menuinicio");

    }
}
