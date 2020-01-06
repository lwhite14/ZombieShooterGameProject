using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public AudioClip activateClip;
    public GameObject gate;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Ball") 
        {
            AudioSource.PlayClipAtPoint(activateClip, transform.position);
            Destroy(gate);
            Destroy(GameObject.Find("Ball"));
        }
    }
}
