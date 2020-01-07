using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGameText : MonoBehaviour
{
    public Text gameOverText;
    int health;
    void Start()
    {
        health = PlayerPrefs.GetInt("Health");
        if (health == 0)
        {
            gameOverText.text = "You Died!";
        }
        else 
        {
            gameOverText.text = "You Survived!";
        }
    }

}
