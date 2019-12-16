using System.Collections;
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

    public void playerDie() 
    {
        Destroy(gameObject);

        GameObject deathPanel = GameObject.Find("Death Panel");
        GameObject deathText = GameObject.Find("Death Text");
        GameObject deathButton = GameObject.Find("Death Button");
        Animator panelAnim = deathPanel.GetComponent<Animator>();
        Animator textAnim = deathText.GetComponent<Animator>();
        Animator buttonAnim = deathButton.GetComponent<Animator>();
        panelAnim.SetBool("isDead", true);
        textAnim.SetBool("isDead", true);
        buttonAnim.SetBool("isDead", true);





        //Image image = deathPanel.GetComponent<Image>();

        //Color c = image.color;
        //c.a = 255;
        //image.color = c;

        //Debug.Log("yeet");
    }
}
