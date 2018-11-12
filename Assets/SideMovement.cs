using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface GenericSideMovement
{
    void Move();
}

public class FrontSideMovement : GenericSideMovement
{
    private float speed;
    private Transform playerTransform;

    public FrontSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(-translation, 0, 0);
    }
}

public class LeftSideMovement : GenericSideMovement
{
    private float speed;
    private Transform playerTransform;

    public LeftSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(0, 0, -translation);
    }
}

public class RightSideMovement : GenericSideMovement
{
    private float speed;
    private Transform playerTransform;

    public RightSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(0, 0, translation);
    }
}

public class BackSideMovement : GenericSideMovement
{
    private float speed;
    private Transform playerTransform;

    public BackSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(translation, 0, 0);
    }
}
