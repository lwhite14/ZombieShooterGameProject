using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    float y;
    public float speed = 2;
    public float lowestY;
    public float highestY;
    float realSpeed;
    bool isWalkingForward;

    void Start()
    {
        realSpeed = speed / 100;
    }

    void Update()
    {
        if (isWalkingForward)
        {
            y -= realSpeed;
        }
        else 
        {
            y += realSpeed;
        }

        if (y < lowestY) 
        {
            isWalkingForward = false;
        }

        if (y > highestY)
        {
            isWalkingForward = true;
        }


        transform.position = new Vector2(transform.position.x, y);
    }
}
