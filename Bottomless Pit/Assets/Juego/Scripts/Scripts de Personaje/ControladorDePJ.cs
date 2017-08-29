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




    void Awake()
    {

        movimiento = GetComponent<CharacterController>();
        animacion = GetComponent<Animator>();
    }


    void FixedUpdate()
    {

       
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
       //velocidad = Input.GetAxis("Horizontal");
       mov += transform.forward * velocidad * Input.GetAxis("Horizontal");
        
        // animacion.SetFloat("velocidad", velocidad);






        movimiento.Move(mov * Time.deltaTime);


        print(movimiento.isGrounded);
      

    }
}
