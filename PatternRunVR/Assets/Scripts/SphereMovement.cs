using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {

    bool didMovementStart = false;
    Rigidbody rigidBody;
    SphereCollider sphereCollider;
    public float speed = 10f;

	// Use this for initialization
	void Start () {
        didMovementStart = true;
        rigidBody = GetComponent<Rigidbody>();
        sphereCollider = GetComponent<SphereCollider>();
	}
	
    void StartMovement()
    {
        Vector3 vector = new Vector3(speed, 0, 0);
        rigidBody.AddForce(vector);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TurnBox"))
        {
            Debug.Log("Hi");
            if (rigidBody.velocity.x != 0)
            {
                Debug.Log("Hi Again");
                rigidBody.velocity = Vector3.zero;
                rigidBody.AddForce(new Vector3(0, 0, speed));
            }
            
        }

        
    }

	// Update is called once per frame
	void Update () {
		if (didMovementStart && rigidBody.velocity.x == 0)
        {
            StartMovement();
        }


	}
}
