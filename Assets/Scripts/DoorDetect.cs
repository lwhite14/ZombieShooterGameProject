using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorDetect : MonoBehaviour
{
    GameObject playerObj;
    GameObject deathPanel;
    GameObject[] zombieObjs;
    Animator panelAnim;
    bool isChanging = false;
    int counter = 0;
    public float xCoord;
    public float yCoord;
    public AudioClip clip;
    float originalSpeed;

    void Start()
    {
        playerObj = GameObject.Find("Hero");
        deathPanel = GameObject.Find("Death Panel");
        panelAnim = deathPanel.GetComponent<Animator>();
        originalSpeed = playerObj.GetComponent<TopDownCharacterController2D>().speed;
    }

    void Update()
    {
        if (isChanging) 
        {
            if (counter > 500)
            {
                playerObj.transform.position = new Vector2(xCoord, yCoord);
                panelAnim.SetBool("isDead", false);
                isChanging = false;
                counter = 0;
                playerObj.GetComponent<TopDownCharacterController2D>().speed = originalSpeed;

                foreach (GameObject zombie in zombieObjs)
                    zombie.GetComponent<Knockback>().GoZombie();

            }
            else 
            {
                foreach (GameObject zombie in zombieObjs)
                    zombie.GetComponent<Knockback>().StopZombie();
            }
            counter += 1;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Wall Collision" || isChanging == false) 
        {
            Animator panelAnim = deathPanel.GetComponent<Animator>();
            panelAnim.SetBool("isDead", true);
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            isChanging = true;
            playerObj.GetComponent<TopDownCharacterController2D>().speed = 0;

            zombieObjs = GameObject.FindGameObjectsWithTag("Enemy");
            //foreach (GameObject zombie in zombieObjs)
            //    zombie.GetComponent<Knockback>().StopZombie();
        }
    }
}
