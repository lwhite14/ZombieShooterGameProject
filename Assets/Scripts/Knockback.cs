using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knockback : MonoBehaviour
{
    private GameObject playerObj = null;
    private GameObject enemyObj = null;
    bool isHurt = false;
    int hurtCounter = 20;

    private void Start()
    {
        playerObj = GameObject.Find("Hero");
        enemyObj = GameObject.FindGameObjectWithTag("Enemy");
    }

    private void Update()
    {
        if (isHurt)
        {
            if (hurtCounter <= 0)
            {
                isHurt = false;
                var enemyRenderer = enemyObj.GetComponent<Renderer>();
                enemyRenderer.material.SetColor("_Color", Color.white);
                hurtCounter = 10;
            }
            else
            {
                hurtCounter -= 1;
            }
            
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Vector2 difference = transform.position - playerObj.transform.position;

        int neg = 1;
        if (difference.x < 0) 
        {
            neg = -1;
        }

        double angle = getAngle(difference.y, difference.x);
        double pushX = getAd(angle) * neg;
        double pushY = getOp(angle) * neg;
    
        transform.position = new Vector2(transform.position.x + (float)pushX, transform.position.y + (float)pushY);

        var enemyRenderer = enemyObj.GetComponent<Renderer>();
        enemyRenderer.material.SetColor("_Color", Color.red);
        isHurt = true;
    }

    private static double getAd(double ang)
    {
        double output;
        output = Math.Cos(ang * (Math.PI / 180.0)) * 2;
        return output;
    }

    private static double getOp(double ang)
    {
        double output;
        output = Math.Sin(ang * (Math.PI / 180.0)) * 2;
        return output;
    }

    private static double getAngle(double Op, double Ad)
    {
        double output;
        output = Math.Atan(Op / Ad) * (180 / Math.PI);
        return output;
    }

}
