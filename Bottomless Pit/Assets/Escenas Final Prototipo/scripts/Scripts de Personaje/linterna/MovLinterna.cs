using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovLinterna : MonoBehaviour
{
    void Update()
    {


        //animacion 
        float precionar = Input.GetAxis("Horizontal");

        if (precionar > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            



        }
        if (precionar < 0)
        {
            transform.localScale = new Vector3(-1, 1, -1);
            
        }
    }
}

