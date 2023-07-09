using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashSound : MonoBehaviour
{
    [SerializeField] private AudioClip[] stoneClips;
    [SerializeField] AudioSource audioSource;
    private void dash()
    {

        AudioClip clip = stoneClips[0];
        audioSource.PlayOneShot(clip);
        
    }
}


