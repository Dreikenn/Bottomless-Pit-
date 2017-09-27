using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDePersonaje1 : MonoBehaviour
{

    public float velocidad = 0.1f;
    private float movimiento;


    private CharacterController personaje;

    //animaciones
    private Animator animacion;


    // Codigo para los Saltos
    public float VelSalto;
    
    private Vector3 velocidadS;
    private bool saltar;

    //daño por caida

    public float UltimaPosY = 0f;
    public float DistancaiDeMuerte = 0f;
    public Transform PJ;

    


    void Awake()
    {
        animacion = GetComponent<Animator>();
        personaje = GetComponent<CharacterController>();
        saltar = true;
        
    }


    void Update()
    {

        float precionar = Input.GetAxis("Horizontal");

        if (precionar > 0)
        {
            movimiento = transform.position.z + (precionar * velocidad);
            transform.position = new Vector3(0, transform.position.y, movimiento);
            transform.localScale = new Vector3(1, 1, 1);
            animacion.SetFloat("velocidad", precionar);



        }
        if (precionar < 0)
        {
            movimiento = transform.position.z + (precionar * velocidad);
            transform.position = new Vector3(0, transform.position.y, movimiento);
            transform.localScale = new Vector3(-1, 1, -1);
            animacion.SetFloat("velocidad", Mathf.Abs(precionar));
        }




        //saltar
        
        
        var MovSalto = Vector3.zero;

        if (personaje.isGrounded)
        {
            var salto = false;
            
            if (Input.GetKeyDown(KeyCode.Space))
            {

                saltar = true;



            }

            //para que no salte en el aire
            if (saltar && Input.GetKeyDown(KeyCode.Space))
            {
                salto = true;
                saltar = false;
            }
            if (salto)
            {
                velocidadS = personaje.velocity;
                velocidadS.y = VelSalto;
            }


        }


        else
        {

            velocidadS.y += Physics.gravity.y * Time.deltaTime;
            

        }
        //gravedad
       

      

        
        MovSalto += velocidadS;
        MovSalto += Physics.gravity;
        MovSalto *= Time.deltaTime;
        
        personaje.Move(MovSalto);


        //daño por caida
        if (UltimaPosY > PJ.transform.position.y)
        {
            DistancaiDeMuerte += UltimaPosY - PJ.transform.position.y;
        }
        UltimaPosY = PJ.transform.position.y;

        if(DistancaiDeMuerte >= 5 && personaje.isGrounded)
        {
            morir();
            ResetCaida();
        }
        if(DistancaiDeMuerte <= 5 && personaje.isGrounded)
        {  
            ResetCaida();
        }


    }
    //es para que los valores de la posicion vieja se reseten , haci no hace como un contador de altura,
    //cada vez que cae y toca el sulo va a 0
    void ResetCaida()
    {
        DistancaiDeMuerte = 0;
        UltimaPosY = 0;
    }

    //insertar pantalla de derrota, animacion de emuerte y volver a cargar el ultimo nivel
    void morir()
    {

		Application.LoadLevel("menumuerto1");
    }


}


