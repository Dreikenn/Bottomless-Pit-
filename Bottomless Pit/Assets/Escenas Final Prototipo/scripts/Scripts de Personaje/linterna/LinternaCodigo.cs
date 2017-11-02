﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinternaCodigo : MonoBehaviour {

    //cordura
    public float tiempo = 5f;
    public Text timerText;
    private int contador = 1;
    public bool Activartiempo = true;

    public GameObject Linterna;

	//energia de la linterna
	public float EnergiaMaxima;
	private float EnergiaActual;
	public GameObject Barra;
    


	[SerializeField]

	private bool Encender = false;
	//Esta variable es static para acceder a ella desde el otro codigo.
	static public float bateria = 1f;

	[SerializeField]

	private float EnergiaMax = 1f;

	[SerializeField]

	private float EnergiaMin = 0f;


    public float z, x, y;

    void Start()
    {
        timerText.text = " " + tiempo;
    }
    void Awake ()
	{
       
        bateria = 1f;
		
        Linterna.SetActive(false);
		EnergiaActual = EnergiaMaxima;
    }
   
    void Update()
    {






        //Si la linterna esta prendida, la energia que guarda la bateria va a ir bajando con el tiempo.
        float precionar = Input.GetAxis("Horizontal");

        if (precionar > 0)
        {
            transform.localScale = new Vector3(x, y, z);
        }
        if (precionar < 0)
        {
            transform.localScale = new Vector3(x, -y, z);
        }


        if (Input.GetKeyDown("e"))
        {
          
            

            //Si apretamos Space y la luz esta encendida se va a apagar. Por eso se setea en falso.
            if (Encender == true)
            {
                Linterna.SetActive(false);
                Encender = false;
                Activartiempo = true;

            }
            //Si la luz esta apagada y la bateria es mayor que la energia minima, la luz se activa por eso se setea en verdadero al final.
            else if (Encender == false && bateria > EnergiaMin)
            {
                Linterna.SetActive(true);
                tiempo = 5f;
                Activartiempo = false;
                Encender = true;
                return;
            }
        }
      

        //Si la linterna esta prendida pero la bateria se agoto, se apaga y se setea en falso.
        if (Encender == true)
        {
            bateria -= 0.1f * Time.deltaTime;
			InvokeRepeating ("Decrecer", 1f, 1f);
           
        }
        if (bateria <= EnergiaMin && Encender == true) 
		{
			Linterna.SetActive (false);
            Activartiempo = true;

            Encender = false;
            
        }

        if (Activartiempo == true)
        {

            tiempo -= Time.deltaTime;
            timerText.text = " " + tiempo.ToString("f0");
        }

        if (tiempo <= 0f)
        {
            Application.LoadLevel("menumuerte");
        }

        //Controla que la bateria no se recargue mas de lo que debe, es decir si la bateria es de diez y se recarga a mas de diez vuelva a ser diez.

        if (bateria >= EnergiaMax)
		{
			bateria = EnergiaMax;
		}

		// Si la bateria esta en numeros negativos vuelve a ser cero.
		else if (bateria <= EnergiaMin) 
		{
			bateria = EnergiaMin;
		}
		
	}

	public void Decrecer()
	{
		

		Barra.transform.localScale = new Vector3(bateria,Barra.transform.localScale.y,Barra.transform.localScale.z);
	}
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Untagged") return;
        if (col.tag == "Player") return;
        if (col.tag == "contraseña")
        { 

        Activartiempo = false;
    }
        

    }
  

    
}
