using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//este codigo es para poder usar las UI
using UnityEngine.UI;
public class ImagenTutorial1 : MonoBehaviour {

	[SerializeField] 
	private Image Tuto1;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Tuto1.enabled = true;	

		}
}
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Tuto1.enabled = false;	
		}
	}

}