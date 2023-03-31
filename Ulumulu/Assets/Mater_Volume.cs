using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Mater_Volume : MonoBehaviour
{
    public AudioMixer KURWA;

    public void SetVolume (float volume)
    {
        KURWA.SetFloat("volume", volume);
    }
}
