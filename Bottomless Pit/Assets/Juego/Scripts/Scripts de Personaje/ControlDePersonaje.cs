using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDePersonaje : MonoBehaviour
{

    public float velocidad = 0.1f;
    private float movimiento;
    public float FuerzaDeSalto;

    private bool tocarsuelo;

    private Animator animacion;
    private Rigidbody rb;


    void Awake()
    {
        animacion = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }


    void FixedUpdate()
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
            animacion.SetFloat("velocidad",Mathf.Abs (precionar));
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            {
                salto();
            }
            tocarsuelo = false;
        }
            
        
    }

    void salto()
    {
        if (tocarsuelo == true)
        {
            rb.velocity = (new Vector3(0, FuerzaDeSalto, 0));
            tocarsuelo = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        tocarsuelo = true;
    }
}

