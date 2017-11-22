using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dañar : MonoBehaviour {
    
    

    private GameObject BarraDeCorazones;
    public AudioSource RomperRoca;
    
    public bool RomperAlContacto;

    void Start()
    {
        BarraDeCorazones = GameObject.Find("Ilustrador");
    }

    void OnTriggerEnter(Collider col)
    {
        if(RomperAlContacto == true && col.tag == "TierraPiedra" )
        {
            RomperRoca.Play();
            Destroy(gameObject);
        }
        if (col.tag == "Player")
        {
            
            BarraDeCorazones.SendMessage("daño", 1);
            RomperRoca.Play();
            Destroy(gameObject);


        }
    }

   
}
