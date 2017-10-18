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
        Application.LoadLevel("Nivel1");

    }
    public void level2()
    {
        //boton.Play();
        Application.LoadLevel("Nivel2");

    }
    public void level3()
	{
	//boton.Play();
        Application.LoadLevel("Nivel3");

    }
}

