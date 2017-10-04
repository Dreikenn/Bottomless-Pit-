using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conseguirvictoria3 : MonoBehaviour {

    void OnTriggerEnter(Collider otro)
    {
        //se deben aplicar los enemigos antes de aplicar este if
        //if (enemigosmuertos == 3){}
        Application.LoadLevel("menuganar");

    }
}
