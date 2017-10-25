using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravedadPiedras : MonoBehaviour {

    private float FG;
    public float G;

    private MeshCollider caida;

	void Start ()
    {
        caida = GetComponent<MeshCollider>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(caida.isTrigger)
        {
            FG = 0;


        }

        FG -= G * Time.deltaTime;
        Vector3 Caer = Vector3.zero;
        Caer.y = FG;

        print(caida.isTrigger);

        
	}
}
