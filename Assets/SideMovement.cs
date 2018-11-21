using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISideMovement
{
    Vector3 GetAxisOfDirectionRelativeLeft();

    void Move();
    void AutoMoveLeft();
    void AutoMoveRight();
}



public static class SideMovementTools
{
    public static Dictionary<string, ISideMovement> GetStringToMovementDictionary(float speed, Transform transform)
    {
        var stringToMovementDict = new Dictionary<string, ISideMovement>()
        {
            { "Front Side" , new FrontSideMovement(speed, transform) },
            { "Right Side", new RightSideMovement(speed, transform) },
            { "Back Side", new BackSideMovement(speed, transform) },
            { "Left Side", new  LeftSideMovement(speed, transform) }
        };
        return stringToMovementDict;
    }

    public static ISideMovement GetSideMovement(GameObject side, float speed, Transform transform)
    {
        var movementDict = GetStringToMovementDictionary(speed, transform);

        ISideMovement currentSideMovement = null;
        try
        {
            currentSideMovement = movementDict[side.name];
        }
        catch (KeyNotFoundException)
        {
            Debug.Log(side.name + " not in Movement Dictionary");
        }
        return currentSideMovement;
    }
}

public class FrontSideMovement : ISideMovement
{
    private float speed;
    private Transform playerTransform;
    private Vector3 axisOfDirectionRelativeLeft;

    public FrontSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
        axisOfDirectionRelativeLeft = new Vector3(1, 0, 0);
    }

    public Vector3 GetAxisOfDirectionRelativeLeft()
    {
        return axisOfDirectionRelativeLeft;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(-translation, 0, 0);
    }

    public void AutoMoveLeft()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(translation, 0, 0);
    }

    public void AutoMoveRight()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(-translation, 0, 0);
    }
}

public class LeftSideMovement : ISideMovement
{
    private float speed;
    private Transform playerTransform;
    private Vector3 axisOfDirectionRelativeLeft;

    public LeftSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
        axisOfDirectionRelativeLeft = new Vector3(0, 0, 1);
    }

    public Vector3 GetAxisOfDirectionRelativeLeft()
    {
        return axisOfDirectionRelativeLeft;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(0, 0, -translation);
    }

    public void AutoMoveLeft()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(0, 0, translation);
    }

    public void AutoMoveRight()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(0, 0, -translation);
    }
}

public class RightSideMovement : ISideMovement
{
    private float speed;
    private Transform playerTransform;
    private Vector3 axisOfDirectionRelativeLeft;

    public RightSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
        axisOfDirectionRelativeLeft = new Vector3(0, 0, -1);
    }

    public Vector3 GetAxisOfDirectionRelativeLeft()
    {
        return axisOfDirectionRelativeLeft;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(0, 0, translation);
    }

    public void AutoMoveLeft()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(0, 0, -translation);
    }

    public void AutoMoveRight()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(0, 0, translation);
    }
}

public class BackSideMovement : ISideMovement
{
    private float speed;
    private Transform playerTransform;
    private Vector3 axisOfDirectionRelativeLeft;

    public BackSideMovement(float speed, Transform playerTransform)
    {
        this.speed = speed;
        this.playerTransform = playerTransform;
        axisOfDirectionRelativeLeft = new Vector3(-1, 0, 0);
    }

    public Vector3 GetAxisOfDirectionRelativeLeft()
    {
        return axisOfDirectionRelativeLeft;
    }

    public void Move()
    {
        float translation = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        playerTransform.Translate(translation, 0, 0);
    }

    public void AutoMoveLeft()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(-translation, 0, 0);
    }

    public void AutoMoveRight()
    {
        float translation = speed * Time.deltaTime;
        playerTransform.Translate(translation, 0, 0);
    }
}
