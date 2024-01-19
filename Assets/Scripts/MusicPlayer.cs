using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] private AudioClip[] audioClips;

    public void Play(int index)
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }

    void Start()
    {
        Play(0);
    }

}