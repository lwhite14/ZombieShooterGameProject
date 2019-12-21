using UnityEngine;
using UnityEngine.UI;
public class GameUI : MonoBehaviour
{
    public Slider healthBar;
    public Text scoreText;
    public Text keysText;
    public int playerScore = 0;
    public int playerKeys = 0;
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