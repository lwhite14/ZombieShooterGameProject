using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioClip clip;

    public void PlayOnDie() 
    {

        AudioSource.PlayClipAtPoint(clip, gameObject.transform.position);       

    }

}
