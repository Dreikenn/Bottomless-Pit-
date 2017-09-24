﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class ControladorDePJ : MonoBehaviour {

    private CharacterController movimiento;
    private Animator animacion;

    private float FuerzaDEGravedad;
    public float velocidad;
    public float FuerzadeSalto;
    
    public float Gravedad;


    //daño por caida
    private float UltimaPosY = 0f;
    private float DistancaiDeMuerte = 0f;
    public float AlturaDeMuerte;
    public Transform PJ;

    //Agacharce
    private float DePie;
    private float Agacharse;
    




    void Awake()
    {
        movimiento = GetComponent<CharacterController>();
        animacion = GetComponent<Animator>();
        DePie = movimiento.height;
        Agacharse = movimiento.height/2.5f;


    }
 



    void OnTriggerEnter(Collider col)
    {
       

        
            movimientobala v = col.GetComponent<movimientobala>();
            Patrulla vz = col.GetComponent<Patrulla>();
            if (v != null)
            {
                Destroy(gameObject);
            }
            if (vz != null)
            {
                Destroy(gameObject);
            }
        



    }

    void Update()
    {

        
        
        //animacion 
        
        float precionar = Input.GetAxis("Horizontal");

        if (precionar > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            animacion.SetFloat("velocidad", precionar);



        }
        if (precionar < 0)
        {
            transform.localScale = new Vector3(-1, 1, -1);
            animacion.SetFloat("velocidad", Mathf.Abs(precionar));
        }

        
        //saltar
        if (movimiento.isGrounded)
        {

            FuerzaDEGravedad = 0;

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                FuerzaDEGravedad = FuerzadeSalto; 

            }
           


        }
        




        FuerzaDEGravedad -= Gravedad * Time.deltaTime;

        

        Vector3 mov = Vector3.zero;
        mov.y = FuerzaDEGravedad;
        mov += transform.forward * velocidad * Input.GetAxis("Horizontal");
       
        movimiento.Move(mov * Time.deltaTime);
        

        print(movimiento.isGrounded);

        //agacharce
        if(Input.GetKey(KeyCode.DownArrow))
        {
            agacharse();
            animacion.SetBool("agachado", true);

        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            pararse();
            animacion.SetBool("agachado", false);
        }
       

        //daño por caida

        if (UltimaPosY > PJ.transform.position.y)
        {
            DistancaiDeMuerte += UltimaPosY - PJ.transform.position.y;
        }
        UltimaPosY = PJ.transform.position.y;

        if (DistancaiDeMuerte >= AlturaDeMuerte && movimiento.isGrounded)
        {
            morir();
            ResetCaida();
        }
        if (DistancaiDeMuerte <= AlturaDeMuerte && movimiento.isGrounded)
        {
            ResetCaida();
        }
       


    }


    void ResetCaida()
    {
        DistancaiDeMuerte = 0;
        UltimaPosY = 0;
    }

    void morir()
    {
		Application.LoadLevel("menumuerte");
    }

 
	
    void agacharse()
    {
        if(movimiento.isGrounded)
        {
            movimiento.height = Agacharse;
            movimiento.center = new Vector3(0f, 0.41f, 0f);
            

        }
    }

    void pararse()
    {

        transform.position = new Vector3(transform.position.x, transform.position.y + 0.3f, transform.position.z);

        movimiento.center = new Vector3(0f, 0.82f, 0f);

        movimiento.height = DePie;


    }


    






}
