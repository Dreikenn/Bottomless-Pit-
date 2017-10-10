using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarVida : MonoBehaviour {

   

    private GameObject Corazones;

    void Start()
    {
        Corazones = GameObject.Find("Ilustrador");
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.tag == "Player")
        {

            Corazones.SendMessage("curar", 1);
            Destroy(gameObject);


        }
    }
}
