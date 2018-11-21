using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 1f;
    public GameObject startingSide;
    public float jforce = 15;

    [HideInInspector]
    public GameObject currentSide;
    private ISideMovement currentSideMovement;
    private Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        SetSide(startingSide);
    }

    // Update is called once per frame
    void Update() {

        currentSideMovement.Move();

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jumping!");
            PlayerJump();
        }

    }



    private void PlayerJump()
    {
        Vector3 f = new Vector3(0, jforce, 0);
        rb.AddForce(f);
    }

    public void KillPlayer()
    {
        Destroy(this.gameObject);
        Debug.Log("Cube Dead :(");
    }


    public void SetSide(GameObject side)
    {
        currentSide = side;
        currentSideMovement = SideMovementTools.GetSideMovement(side, speed, transform);
        var movementDict = SideMovementTools.GetStringToMovementDictionary(speed, transform);
    }



}