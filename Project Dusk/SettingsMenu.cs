﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audiomixer;

    public void SetVolume (float volume)//AudioMixer/VolumeSetter Float param
    {
        audiomixer.SetFloat("volumeParam", volume);
    }
}
