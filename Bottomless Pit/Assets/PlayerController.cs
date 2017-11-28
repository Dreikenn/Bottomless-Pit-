using UnityEngine;

/// <summary>
/// Simple player controller based on a Rigidbody
/// </summary>
public class PlayerController : MonoBehaviour
{

    private Rigidbody thisRigidbody;

    void Start()
    {
        thisRigidbody = GetComponent<Rigidbody>();

    }


    void OnCollisionEnter(Collision collision)
    {
      

        if (collision.gameObject.tag == "Enemy")
        {
            thisRigidbody.transform.position = CheckPoint.GetActiveCheckPointPosition();
        }
    }
}