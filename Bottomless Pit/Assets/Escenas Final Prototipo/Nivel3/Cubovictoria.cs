using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubovictoria : MonoBehaviour {

    public GameObject cubo;
    int variable2;
    public GameObject objetito;


    void OnTriggerEnter(Collider otro)
    {
        objetito.SendMessage("sumarcubo");
        Destroy(this.cubo);
        
	}
	
}
