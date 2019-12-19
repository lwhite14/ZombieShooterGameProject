using UnityEngine;
using System.Collections;
public class TopDownCharacterController2D : MonoBehaviour
{
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    private Animator walkAnim;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        walkAnim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (speed > 0)
        {
            if ((x != 0) | (y != 0))
            {
                if (y > 0)
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
            else
            {
                walkAnim.SetBool("isWalkingForward", false);
                walkAnim.SetBool("isWalkingBackward", false);
            }
        }
        else 
        {
            walkAnim.SetBool("isWalkingForward", false);
            walkAnim.SetBool("isWalkingBackward", false);
        }

        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;
    }}