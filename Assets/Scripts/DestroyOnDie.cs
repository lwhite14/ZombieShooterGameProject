﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDie : MonoBehaviour
{
    void Start()
    {

    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
