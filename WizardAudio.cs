using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAudio : MonoBehaviour {

    public AudioClip StartAudio;
    public AudioClip StayAudio;
    public AudioClip FinishAudio;

    private AudioSource AudioSource;

    private void Start()
    {
        AudioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        AudioSource.clip = StartAudio;
        AudioSource.Play();
    }

    private void OnTriggerStay(Collider other)
    {
        if (!AudioSource.isPlaying)
        {
            AudioSource.clip = StayAudio;
            AudioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        AudioSource.playOnAwake = false;
        AudioSource.clip = FinishAudio;
        AudioSource.Play();
    }
}
