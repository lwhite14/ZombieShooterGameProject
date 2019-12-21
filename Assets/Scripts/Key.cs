using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public delegate void UpdateKeys(int keys);
    public static event UpdateKeys OnUpdateKeys;
    public int keysAmount;
    public AudioClip clip;

    private void OnTriggerEnter2D(Collider2D other)
    {
        addKey(other, keysAmount);
    }
    public void addKey(Collider2D other, int key) 
    {
        if (other.name == "Wall Collision")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);
            OnUpdateKeys(key);


        }
    }
}
