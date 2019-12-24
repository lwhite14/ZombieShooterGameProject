using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool isDead = false;
    int counter = 0;

    void Update() 
    {
        if (isDead) 
        {
            if (counter > 600) 
            {
                SceneManager.LoadScene("Game Over");
            }
            counter += 1;
        }
        
    }



    public void StartGame()
    {
        SceneManager.LoadScene("Zombie Shooter Level 1");
    }

    public void GameOver() 
    {
        GameObject deathPanel = GameObject.Find("Death Panel");
        Animator panelAnim = deathPanel.GetComponent<Animator>();
        panelAnim.SetBool("isDead", true);
        isDead = true;
    }
}
