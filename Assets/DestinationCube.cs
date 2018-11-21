using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationCube : MonoBehaviour {
    public GameObject Side;
    private Vector3 position;


	// Use this for initialization
	void Start () {
        position = this.gameObject.transform.position;
	}

	public Vector3 GetPosition()
    {
        return position;
    }
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Cube Triggered");
    }
}
