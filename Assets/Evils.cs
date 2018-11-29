using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evils : MonoBehaviour {

    Player player;
    [HideInInspector]
    public ISideMovement currentSideMovement;
    public GameObject startingSide;
    public GameObject currentSide;
    public float speed = 1f;
    private bool patrolMode = true;
    private bool followingPlayer = false;
    public string directionOfMovement;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Mr.Cube").GetComponent<Player>();
        currentSideMovement = SideMovementTools.GetSideMovement(startingSide, speed, transform);
        directionOfMovement = "left";
        currentSide = startingSide;
    }
	
	// Update is called once per frame
	void Update () {

        FollowPlayer();


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


    void FollowPlayer()
    {
        // Check if player is on same platform and if so change direction to follow it
        var onSamePlatform = IsOnSamePlatformAsPlayer();
        if (!onSamePlatform)
        {
            followingPlayer = false;
            return;
        }

        if (onSamePlatform)
        {
            followingPlayer = true;
            var relativeDirection = LeftOrRight.GetRelativeDirection(player.gameObject, gameObject);
            directionOfMovement = relativeDirection;
        }
        
    }
     
    bool IsOnSamePlatformAsPlayer()
    {
        if (currentSide == player.currentSide)
        {
            return true;
        }
        return false;
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




}


