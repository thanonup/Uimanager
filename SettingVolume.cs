﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingVolume : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider slider;
    float _volume;

    public void Setvolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
        _volume = volume;
    }

    private void Start()
    {
        audioMixer.SetFloat("volume", PlayerPrefs.GetFloat("_volume", _volume));
        slider.value = PlayerPrefs.GetFloat("_volume", _volume);
    }
    private void OnDisable()
    {
        PlayerPrefs.SetFloat("_volume", _volume);
        PlayerPrefs.Save();
    }
}
