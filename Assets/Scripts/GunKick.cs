using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GunKick : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {

    }


    public void kickBack()
    {
        GameObject knockObj = GameObject.Find("KnockBack");

        Vector2 difference = transform.position - knockObj.transform.position;

        transform.position = new Vector2(transform.position.x + difference.x, transform.position.y + difference.y);
    }
}