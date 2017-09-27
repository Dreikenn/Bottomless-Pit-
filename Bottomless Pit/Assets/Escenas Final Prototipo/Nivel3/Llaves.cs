using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llaves : MonoBehaviour {

    public GameObject lasllaves;
    int variable2;
    public GameObject objetito;


    void OnTriggerEnter(Collider otro)
    {
        objetito.SendMessage("sumarllaves");
        Destroy(this.lasllaves);
        
	}
	
}
