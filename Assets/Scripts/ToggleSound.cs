using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSound : MonoBehaviour
{
    public AudioSource source;

    public void TogglePlay()
    {

        if (source.isPlaying) {
            source.Stop();
        }
        else
        {
            source.Play();
        }
    }
}
