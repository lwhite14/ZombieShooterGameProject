﻿using UnityEngine;
using UnityEngine.Events;


public class OnHealedEvent : UnityEvent<int> { }
public class HealthPickup : MonoBehaviour
{
    int oldHealth;
    int newHealth;
    HealthSystem healthComp;
    GameObject playerObj;
    public OnDamagedEvent onHealed;
    public AudioClip clip;

    void Start()
    {
    }

    void Update()
    {
        playerObj = GameObject.Find("Hero");
        healthComp = playerObj.GetComponent<HealthSystem>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        addHealth(other);
    }

    public void addHealth(Collider2D other) 
    {
        if (other.name == "Wall Collision")
        {       
            Destroy(gameObject);
            oldHealth = healthComp.health;
            newHealth = oldHealth + 10;

            if (newHealth > 50)
            {
                healthComp.health = 50;
            }
            else 
            {
                healthComp.health = newHealth;
            }
            AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));
            onHealed.Invoke(healthComp.health);
        }
    }
}
