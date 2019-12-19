using UnityEngine;
using UnityEngine.Events;


public class OnHealedEvent : UnityEvent<int> { }
public class HealthPickup : MonoBehaviour
{
    int oldHealth;
    int newHealth;
    HealthSystem healthComp;
    GameObject playerObj;
    public OnDamagedEvent onHealed;

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

            Debug.Log("New Health = " + newHealth);

            if (newHealth > 50)
            {
                healthComp.health = 50;
            }
            else 
            {
                healthComp.health = newHealth;
            }

            Debug.Log("Actual New Health = " + healthComp.health);

            onHealed.Invoke(healthComp.health);
        }
    }
}
