
using UnityEngine;

public class Camara : MonoBehaviour {

	public Transform p;

	public float SmoothSpeed= 0.125f;
	public Vector3 offset;


	void Update () {
	transform.position = p.position + offset;	

		
	}
}
