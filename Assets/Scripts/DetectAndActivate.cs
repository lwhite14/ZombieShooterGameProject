using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAndActivate : MonoBehaviour
{
    public GameObject[] spawners;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Wall Collision")
        {
            foreach (GameObject spawner in spawners)
                spawner.SetActive(true);
        }
    }
}
