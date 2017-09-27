using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Managerdellvl3 : MonoBehaviour
{
    public static Managerdellvl3 instance;
    public int llaves;
    public int v;

    public void sumarcubo()
    {
        v += 1;
    }

    public void sumarllaves()
    {
        llaves += 1;
    }

    void Awake()
    {
        if (instance == null)
        {   
            instance = this;
        }
    }
} 

