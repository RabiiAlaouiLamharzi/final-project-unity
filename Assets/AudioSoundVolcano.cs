using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSoundVolcano : MonoBehaviour
{
    public AudioSource src;
    public AudioClip explosion;
    private bool shouldPlay = true;

    public void Button1()
    {
        if (shouldPlay)
        {
            src.clip = explosion;
            src.Play();
        }
        shouldPlay = !shouldPlay;
    }
}
