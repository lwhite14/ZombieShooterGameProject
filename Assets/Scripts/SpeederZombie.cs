using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederZombie : MonoBehaviour
{
    AILerp lerp;
    int counter = 0;
    bool isLow = true;

    void Start()
    {
    }

    void Update()
    {
        AILerp lerp = gameObject.GetComponent<AILerp>();
        if (isLow)
        {
            if (counter > 200)
            {
                updateSpeed(isLow, lerp);
                isLow = false;
                counter = 0;
            }
        }
        else 
        {
            if (counter > 80) 
            {
                updateSpeed(isLow, lerp);
                isLow = true;
                counter = 0;
            }
        }


        counter += 1;
    }

    void updateSpeed(bool isLow, AILerp lerp) 
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
}
