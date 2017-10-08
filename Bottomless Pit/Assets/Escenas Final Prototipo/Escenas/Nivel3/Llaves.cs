using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llaves : MonoBehaviour {

    public GameObject lasllaves;
    int variable2;
    public GameObject objetito;
    AudioSource llave;

    private void Awake()
    {
        llave = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider otro)
    {
        llave.Play();
        objetito.SendMessage("sumarllaves");
        Destroy(this.lasllaves);
        
	}
    private void Update()
    {
        transform.Rotate(0, 1, 0);
    }
}
