using System;
using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;
    public Text keysText;
    public int playerScore;
    public int playerKeys = 0;
    private int score;
    private int health;

    private void Start() 
    {
        score = PlayerPrefs.GetInt("Score");
        health = PlayerPrefs.GetInt("Health");
        playerScore = score;
        UpdateScore(0);
        UpdateHealthBar(health);
    }

    private void OnEnable()
    {
        Player.OnUpdateHealth += UpdateHealthBar;
        AddScore.OnSendScore += UpdateScore;
        Key.OnUpdateKeys += UpdateKeys;
    }
    private void OnDisable()
    {
        Player.OnUpdateHealth -= UpdateHealthBar;
        AddScore.OnSendScore -= UpdateScore;
        Key.OnUpdateKeys -= UpdateKeys;
        PlayerPrefs.SetInt("Score", playerScore);
        PlayerPrefs.SetInt("Health", Convert.ToInt32(healthBar.value));
    }
    private void UpdateHealthBar(int health)
    {
        healthBar.value = health;
    }
    private void UpdateScore(int theScore)
    {
        playerScore += theScore;
        scoreText.text = "SCORE: " + playerScore.ToString();
    }

    private void UpdateKeys(int keysAmount) 
    {
        playerKeys += keysAmount;
        keysText.text = "KEYS: " + playerKeys.ToString();
    
    }
}