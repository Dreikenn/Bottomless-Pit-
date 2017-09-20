using System.Collections;
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

    //trepar
    private bool Trepar;
    public float velocidadAlTrepar;




    void Awake()
    {
        
        movimiento = GetComponent<CharacterController>();
        animacion = GetComponent<Animator>();

    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "climb")
        {
            Trepar = true;
        }

        if (Trepar == false)
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

            if (Input.GetKeyDown(KeyCode.Space))
            {
                FuerzaDEGravedad = FuerzadeSalto; 

            }
           


        }

      

        

        FuerzaDEGravedad -= Gravedad * Time.deltaTime;



        Vector3 mov = Vector3.zero;
        mov.y = FuerzaDEGravedad;
       
       mov += transform.forward * velocidad * Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.UpArrow) && Trepar == true)
        {
            
            mov += transform.up * velocidadAlTrepar * Time.deltaTime;

            FuerzaDEGravedad = 0;
            Gravedad = 0;
            
        }
        if (Input.GetKey(KeyCode.DownArrow) && Trepar == true)
        {

            mov -= transform.up * velocidadAlTrepar * Time.deltaTime;

            FuerzaDEGravedad = 0;
            Gravedad = 0;
        }

        if (Trepar == false)
        {

            Gravedad = 20;
        }
        



        movimiento.Move(mov * Time.deltaTime);

        print(movimiento.isGrounded);

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

   
    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "climb")
        {
            Trepar = false;
        }
    }


    void ResetCaida()
    {
        DistancaiDeMuerte = 0;
        UltimaPosY = 0;
    }

    void morir()
    {
		Application.LoadLevel("Muerto");
    }
	//morir por enemigos

   







}
