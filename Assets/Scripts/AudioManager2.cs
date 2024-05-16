using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{
    [Header("Audio Source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header ("Audio Clip")]

    public AudioClip background;
    


    private void Start()
    {

        musicSource.clip = background;
        musicSource.Play();

    }

  
}
