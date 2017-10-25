using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menudeinicio : MonoBehaviour {

    AudioSource boton;

    private void Awake()
    {
        boton = GetComponent<AudioSource>();
    }


    public void level1()
    {
        //boton.Play();
        Application.LoadLevel("NivelFinal");

    }
   
}

