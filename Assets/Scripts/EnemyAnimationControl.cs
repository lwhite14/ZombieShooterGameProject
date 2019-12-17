using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationControl : MonoBehaviour
{

    private Animator walkAnim;
    float previousY;
    float currentY;
    float diff;
    // Start is called before the first frame update
    void Start()
    {
        walkAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        currentY = transform.position.y;


        Debug.Log(diff);
        //Debug.Log();


        diff = currentY - previousY;
        if (diff == 0)
        {
            walkAnim.SetBool("isWalkingForward", false);
            walkAnim.SetBool("isWalkingBackward", false);
        }
        else
        {
            if (diff > 0)
            {
                walkAnim.SetBool("isWalkingForward", false);
                walkAnim.SetBool("isWalkingBackward", true);
            }
            else
            {
                walkAnim.SetBool("isWalkingForward", true);
                walkAnim.SetBool("isWalkingBackward", false);
            }
        }

        previousY = transform.position.y;
    }

}

