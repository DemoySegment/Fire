using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManager : MonoBehaviour
{
    public AudioSource SoundAudio;

    public void MusicToggle()
    {
        if(SoundAudio.isPlaying)
        {
            SoundAudio.Pause();
        } else {
            SoundAudio.Play();
        }
    }
}
