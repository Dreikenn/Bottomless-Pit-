using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mochituscamina : MonoBehaviour {

    public float v;
    public int t;
    private Animator ani;

    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        t++;
        ani.SetBool("caminar", true);
        
        if(t <100)
        {
            transform.Translate(v, 0, 0);
        }
        if (t > 100 && t < 200)
        {
            transform.Translate(-v, 0, 0);
            t = 0;
        }
    }
}
