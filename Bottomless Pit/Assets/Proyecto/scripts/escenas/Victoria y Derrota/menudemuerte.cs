using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menudemuerte : MonoBehaviour {

    AudioSource boton1;
    AudioSource boton2;


    private void Awake()
    {
        boton1 = GetComponent<AudioSource>();
        boton2 = GetComponent<AudioSource>();
    }


    public void level1()
    {
        //boton1.Play();
        Application.LoadLevel("Nivel1");

    }
    
    public void comienzo()
    {
        //boton2.Play();
        Application.LoadLevel("menuinicio");

    }
  
}
