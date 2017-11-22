using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conseguirvictoria2 : MonoBehaviour {

    void OnTriggerEnter(Collider otro)
    {
        Application.LoadLevel("Nivel3");

    }
}
