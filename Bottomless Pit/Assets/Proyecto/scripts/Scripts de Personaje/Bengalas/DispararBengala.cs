using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DispararBengala : MonoBehaviour {


	public GameObject Bengala;
	public Transform reset;
	public float cadena;
	private float siguiente;
	static public float BengalasMaximas;
	public Text MostrarBengalas;
    // Use this for initialization
    void Awake()
    {
        BengalasMaximas = 3;
    }
    void Start () {

	}

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Space) && Time.time>siguiente && BengalasMaximas >=1)
		{
			Instantiate (Bengala, reset.position, reset.rotation);
			siguiente = Time.time + cadena;
			BengalasMaximas -= 1;

			
		}
        MostrarBengalas.text = BengalasMaximas.ToString("f0");
    }

}
