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
    Animator walkingAnim;

    void Start()
    {
        y = lowestY;
        realSpeed = speed / 100;
        walkingAnim = GetComponent<Animator>();
    }

    void Update()
    {
        if (isWalkingForward)
        {
            y -= realSpeed;
            walkingAnim.SetBool("isWalkingForward", true);
        }
        else 
        {
            y += realSpeed;
            walkingAnim.SetBool("isWalkingForward", false);
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
