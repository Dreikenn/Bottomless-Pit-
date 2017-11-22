using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temporizador : MonoBehaviour {

    public float tiempo = 5f; 
    
    public Text timerText;
    
    private int contador = 1;
    private bool Frenar = false;

    void Start()
    {
        timerText.text = " " + tiempo;
       
    }

    void Update()
    {
        contador = 1;
        if (contador == 0)
        {
            return;
        }

        if (Input.GetKeyDown("e"))
        {
           
            contador++;
           
            if (contador == 2)
            {
                tiempo = 5f;
                contador = 0;
                
            }
            
            
            





        }
       


        tiempo -= Time.deltaTime;
        timerText.text = " " + tiempo.ToString("f0");

        if (tiempo <=0f)
        {
            Application.LoadLevel("menumuerte");
        }
        
      

    }

  


   
}

