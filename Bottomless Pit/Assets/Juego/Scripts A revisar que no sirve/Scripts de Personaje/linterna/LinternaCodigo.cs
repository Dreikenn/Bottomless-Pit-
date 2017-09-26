using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinternaCodigo : MonoBehaviour {

	public GameObject Linterna;
    


	[SerializeField]

	public bool Encender = false;
	//Esta variable es static para acceder a ella desde el otro codigo.
	static public float bateria = 10f;

	[SerializeField]

	private float EnergiaMax = 10f;

	[SerializeField]

	private float EnergiaMin = 0f;


    public float z, x, y;

	void Update () 
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
        if (Encender == true)
		{
			bateria -= 1 * Time.deltaTime;
		}

		if(Input.GetKeyDown("e"))
		{
			//Si apretamos Space y la luz esta encendida se va a apagar. Por eso se setea en falso.
			if (Encender == true) 
			{
				Linterna.SetActive (false);

				Encender = false;
			} 
			//Si la luz esta apagada y la bateria es mayor que la energia minima, la luz se activa por eso se setea en verdadero al final.
			else if (Encender == false && bateria > EnergiaMin)
			{
				Linterna.SetActive (true);

				Encender = true;
			}
		}

		//Si la linterna esta prendida pero la bateria se agoto, se apaga y se setea en falso.

		if (bateria <= EnergiaMin && Encender == true) 
		{
			Linterna.SetActive (false);

			Encender = false;
		}

		//Controla que la bateria no se recargue mas de lo que debe, es decir si la bateria es de diez y se recarga a mas de diez vuelva a ser diez.

		if(bateria >= EnergiaMax)
		{
			bateria = EnergiaMax;
		}

		// Si la bateria esta en numeros negativos vuelve a ser cero.
		else if (bateria <= EnergiaMin) 
		{
			bateria = EnergiaMin;
		}
		
	}
}
