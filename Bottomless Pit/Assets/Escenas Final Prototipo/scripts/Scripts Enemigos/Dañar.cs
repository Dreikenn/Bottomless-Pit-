using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañar : MonoBehaviour {
    public float DMG = 1;

    private GameObject BarraDeCorazones;

    void Start()
    {
        BarraDeCorazones = GameObject.Find("Ilustrador");
    }

    void OnTriggerEnter(Collider col)
    {
        
        if (col.tag == "Player")
        {

            BarraDeCorazones.SendMessage("daño", 1);
           
           
        }
    }

   
}
