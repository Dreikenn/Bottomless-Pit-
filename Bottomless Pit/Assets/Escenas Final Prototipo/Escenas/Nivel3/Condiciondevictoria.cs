using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condiciondevictoria : MonoBehaviour
{
    public int llavesdevictoria;
    public int cubodevictoria;
    void Update()
    {
        if (Managerdellvl3.instance.llaves >= llavesdevictoria)
        {
            if (Managerdellvl3.instance.v >= cubodevictoria)
            {
            

                    Application.LoadLevel("menuganar");
            }
        }
    }
}
