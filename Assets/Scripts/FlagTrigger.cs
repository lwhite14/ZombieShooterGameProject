﻿using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlagTrigger : MonoBehaviour
{
    GameObject deathPanel;
    Animator panelAnim;
    bool isOver = false;
    int counter = 0;
    public AudioClip clip;
    AILerp[] lerps;
    public string scene;

    void Start()
    {
        
    }

    void Update()
    {
        if (isOver) 
        {
            if (counter > 400)
            {
                SceneManager.LoadScene(scene);
            }
            counter += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Wall Collision")
        {
            deathPanel = GameObject.Find("Death Panel");
            panelAnim = deathPanel.GetComponent<Animator>();
            panelAnim.SetBool("isDead", true);
            isOver = true;
            GameObject.Find("Hero").GetComponent<TopDownCharacterController2D>().speed = 0;
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);

            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            //for(int counter = 0; counter < enemies.Length; counter++)
            //    lerps[counter] = enemies[counter].GetComponent<AILerp>();

            //foreach (AILerp lerp in lerps)
            //    lerp.speed = 0;

            foreach (GameObject enemy in enemies)
                Destroy(enemy);

        }
    }
}
