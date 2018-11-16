using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evils : MonoBehaviour {

    Player player;
    private GenericSideMovement currentSideMovement;
    public int currentSide;
    public float speed = 1f;
    private bool patrolMode = true;
    private bool followingPlayer = false;
    public string directionOfMovement;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Mr.Cube").GetComponent<Player>();
        currentSideMovement = new LeftSideMovement(speed, transform);
        currentSide = 3;
        directionOfMovement = "left";
    }
	
	// Update is called once per frame
	void Update () {

        Move();
	}

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Evil Triggered");

        Player player = other.GetComponent<Player>();
        if (player != null)
        {
            player.KillPlayer();
        }

        DestinationCube cube = other.GetComponent<DestinationCube>();
        if (cube != null && followingPlayer == false)
        {
            ReverseDirection();
        }
        
    }

    void Move()
    {
        if (directionOfMovement == "left")
        {
            currentSideMovement.AutoMoveLeft();
        }
        else if (directionOfMovement == "right")
        {
            currentSideMovement.AutoMoveRight();
        }
    }

     
    void IsOnSamePlatformAsPlayer()
    {
        var playerSide = player;
    }

    void SetMovementDirectionToPlayerSide()
    {
       
    }

    void ReverseDirection()
    {
        if (directionOfMovement == "left")
        {
            directionOfMovement = "right";
        }
        else if (directionOfMovement == "right")
        {
            directionOfMovement = "left";
        }
    }

    void InitialPatrolMovement()
    {

    }




    void Patrol()
    {
    }

    public void SetSide(int side)
    {
        currentSide = side;

        switch (side)
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


