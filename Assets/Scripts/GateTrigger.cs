﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTrigger : MonoBehaviour
{
    GameObject canvasObj;
    public AudioClip clip;
    int keys;
    public 

    void Start()
    {
        canvasObj = GameObject.Find("Canvas");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Wall Collision")
        {
            keys = canvasObj.GetComponent<GameUI>().playerKeys;
            if (keys > 0) 
            {
                AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
                Destroy(gameObject);
                canvasObj.GetComponent<GameUI>().playerKeys -= 1;
                canvasObj.GetComponent<GameUI>().keysText.text = "KEYS: " + (keys - 1).ToString();
            }

        }
    }
}