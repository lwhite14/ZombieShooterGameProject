using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour
{
    public AudioClip clip;

    public void PlayOnDie() 
    {

        AudioSource.PlayClipAtPoint(clip, new Vector3(0, 0, 0));       

    }

}
