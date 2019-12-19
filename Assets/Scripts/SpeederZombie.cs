using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederZombie : MonoBehaviour
{
    public AILerp lerp;
    int counter = 0;
    bool isLow = true;

    void Start()
    {
        lerp = gameObject.GetComponent<AILerp>();
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
            if (counter > 80) 
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
            lerp.speed = 1;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        lerp.speed = 1;
        counter = 0;
        isLow = true;
    }
}
