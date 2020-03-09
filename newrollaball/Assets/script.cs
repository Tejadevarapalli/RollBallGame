using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update

    public float bouncePower = 10;

    void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb=collision.gameObject.GetComponent<Rigidbody>();
        PlayerController pc = collision.gameObject.GetComponent<PlayerController>();

        Vector3 bounce = Vector3.Reflect(pc.lastVelocity, collision.contacts[0].normal);
        


        rb.AddForce(bounce.normalized*bouncePower);
        


    }
}
