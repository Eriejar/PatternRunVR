using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBox : MonoBehaviour {

    BoxCollider boxCollider;
    bool enter = true;
	// Use this for initialization
	void Start () {
        boxCollider = GetComponent<BoxCollider>();
	}
	

	// Update is called once per frame
	void Update () {
		
	}
}
