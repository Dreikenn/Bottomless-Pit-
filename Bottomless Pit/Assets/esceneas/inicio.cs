using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inicio : MonoBehaviour {

    public void SiguienteNivel()
    {
        Application.LoadLevel("Prototipo");

    }
	public void SiguienteNivel2()
	{
		Application.LoadLevel("Puzz");
	}
}
