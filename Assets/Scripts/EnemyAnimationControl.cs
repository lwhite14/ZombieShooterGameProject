using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationControl : MonoBehaviour
{

    private Animator walkAnim;
    private GameObject selfObj;
    private GameObject playerObj;
    // Start is called before the first frame update
    void Start()
    {
        walkAnim = GetComponent<Animator>();
        selfObj = gameObject;
        playerObj = GameObject.Find("Hero");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 difference = playerObj.transform.position - selfObj.transform.position;

        Knockback knockBack = selfObj.GetComponent<Knockback>();

        if (knockBack.isHurt == false)
        {
            if (difference.y > 0)
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
    }
}


