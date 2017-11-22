using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Corazones : MonoBehaviour {

    public float CantidadDeVida;
    public Image corazon;
    public AudioSource ouch;
    public AudioSource muerte;


    void Start () {



        DibujarVida(CantidadDeVida);

    }
	
	// Update is called once per frame
	void Update () {

       
    }

    void DibujarVida(float cantidad)
    {
        Image C;
        for(int i=0; i< cantidad; i++)
        {
            C = Instantiate<Image>(corazon);
            C.transform.SetParent(this.transform, false);
            C.transform.Translate(60 * i, 0, 0);
            C.name = "Heart" + i;
        }
    }

    void DesaparecerVida(float num, bool estado)
    {
        GameObject[] hearts;
        hearts = GameObject.FindGameObjectsWithTag("Corazon");

        for (int i=0; i<hearts.Length; i++)
        {
            if (hearts[i].name == "Heart" + num)hearts[i].SetActive(estado);
        }
     
    }

    void AparecerVida(float num, bool estado)
    {
        GameObject[] hearts;
        hearts = GameObject.FindGameObjectsWithTag("Corazon");

        for(int i= 0; i > hearts.Length;i++)
        {
            if(hearts[i].name == "Heart" + num)hearts[i].SetActive(estado);
        }
    }

    public void daño(float daño)
    {
        CantidadDeVida -= daño;
        ouch.Play();
        DesaparecerVida(CantidadDeVida, false);

        if (CantidadDeVida <= 0)
        {
            muerte.Play();

            

            Application.LoadLevel("menumuerte");
        }
    }

    public void curar(float curar)
    {
        CantidadDeVida += curar;
        DibujarVida(CantidadDeVida);


    }



}
