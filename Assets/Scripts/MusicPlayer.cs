using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioSource audioSource3;
    public AudioSource audioSource4;

    public AudioListener audioListener;

    [SerializeField] bool musicStarted;

    private void Awake()
    {
        audioListener = audioListener.GetComponent<AudioListener>();
    }
    void Start()
    {
        audioSource.PlayDelayed(0);
        audioSource2.PlayDelayed(25);
        audioSource3.PlayDelayed(50);
        audioSource4.PlayDelayed(75);
    }

}

