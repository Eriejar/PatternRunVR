using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour {

    bool startMovement = false;
    bool movementInitated = false;
    Rigidbody rigidBody;
    SphereCollider sphereCollider;
    public float speed = 10f;
    public Vector3 oppositeForce = new Vector3(-1, -1, -1);

	// Use this for initialization
	void Start () {
        startMovement = true;
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
            if (true)
            {
                Debug.Log("Hi Again");
                var origVelocity = rigidBody.velocity;
                rigidBody.velocity = Vector3.zero;
                rigidBody.angularVelocity = Vector3.zero;
                Debug.Log(origVelocity);
                Debug.Log(Vector3.Cross(Vector3.down, origVelocity));
                rigidBody.AddForce(Vector3.Cross(Vector3.down, origVelocity).normalized * speed);
            }
            
        }

        
    }

	// Update is called once per frame
	void Update () {
		if (startMovement && !movementInitated)
        {
            Debug.Log("Starts Movement");
            StartMovement();
            movementInitated = true;
        }
        


    }
}
