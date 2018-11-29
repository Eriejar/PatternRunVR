using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LeftOrRight
{
    static public string GetRelativeDirection(GameObject player, GameObject enemy)
    {
        // Returns direction of what object2 is in relation to object1 (if object 2 is on left of object 1 (pivot), returns "left")
        var playerComponent = player.GetComponent<Player>();
        var enemyComponent = enemy.GetComponent<Evils>();

        var playerMovement = playerComponent.currentSideMovement;
        var enemyMovement = enemyComponent.currentSideMovement;

        var side = playerComponent.currentSide;
        var leftDirection = playerMovement.GetAxisOfDirectionRelativeLeft();
        // left: (-1, 0, 0)
        var playerVector = player.transform.position;
        var enemyVector = enemy.transform.position;

        var playerPosition = 0f;
        var enemyPosition = 0f;

        if (leftDirection.x != 0)
        {
            playerPosition = playerVector.x; // 3
            enemyPosition = enemyVector.x; // 2
            
        }
        if (leftDirection.z != 0)
        {
            playerPosition = playerVector.z; // 3
            enemyPosition = enemyVector.z; // 2
        }

        if (leftDirection.x < 0 || leftDirection.z < 0)
        {
            // if a value1 is less than value2, then it is left of
            if (playerPosition < enemyPosition)
            {
                var entityOnLeft = player;
                return "left";
            }
            else
            {
                var entityOnLeft = enemy;
                return "right";
            }
        }
        else
        {
            // if a value 1 is less than value2, then it is right of
            if (playerPosition > enemyPosition)
            {
                var entityOnLeft = player;
                return "left";
            }
            else
            {
                var entityOnLeft = enemy;
                return "right";
            }
        }
        


    }
}
