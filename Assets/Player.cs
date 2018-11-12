using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 1f;
    private GenericSideMovement currentSideMovement;
    public int currentSide;

    Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        currentSideMovement = new LeftSideMovement(speed, transform);
        currentSide = 3;
	}
	
	// Update is called once per frame
	void Update () {
        currentSideMovement.Move();           
	}


    public void SetSide(int side)
    {
        currentSide = side;

        switch(side)
        {
            case 0:
                currentSideMovement = new FrontSideMovement(speed, transform);
                break;
            case 1:
                currentSideMovement = new RightSideMovement(speed, transform);
                break;
            case 2:
                currentSideMovement = new BackSideMovement(speed, transform);
                break;
            case 3:
                currentSideMovement = new LeftSideMovement(speed, transform);
                break;
        }

    }



}