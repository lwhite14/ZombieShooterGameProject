using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederZombie : MonoBehaviour
{
    AILerp lerp;
    int counter = 0;
    bool isLow = true;
    float speed;

    void Start()
    {
        lerp = gameObject.GetComponent<AILerp>();
        speed = lerp.speed;
    }

    void Update()
    {
        //AILerp lerp = gameObject.GetComponent<AILerp>();
        if (isLow)
        {
            if (counter > 200)
            {
                updateSpeed(isLow);
                isLow = false;
                counter = 0;
            }
        }
        else 
        {
            if (counter > 120) 
            {
                updateSpeed(isLow);
                isLow = true;
                counter = 0;
            }
        }


        counter += 1;
    }

    void updateSpeed(bool isLow) 
    {
        if (isLow)
        {
            lerp.speed = 10;
        }
        else 
        {
            lerp.speed = speed;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        lerp.speed = speed;
        counter = 0;
        isLow = true;
    }
}
