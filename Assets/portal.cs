using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour {
    public DestinationCube Destination;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider other)
    {
        Player thingWithSide = other.gameObject.GetComponent<Player>();
        var newPosition = Destination.GetPosition();
        // Preserving y axis position upon teleportation
        newPosition.y = thingWithSide.transform.position.y;
        thingWithSide.transform.position = newPosition;
        thingWithSide.SetSide(Destination.Side);
    }
}
