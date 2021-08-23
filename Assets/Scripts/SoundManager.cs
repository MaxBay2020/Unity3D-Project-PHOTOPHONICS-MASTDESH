using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager _instance;
    private AudioSource audioSource;
    public AudioClip mSound, aSound, sSound, tSound, dSound, eSound, shSound, congratdSound;
    //public List<AudioClip> allSounds = new List<AudioClip>();

    private void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void mSoundPlay()
    {
        audioSource.PlayOneShot(mSound);
    }

    public void aSoundPlay()
    {
        audioSource.PlayOneShot(aSound);
    }

    public void sSoundPlay()
    {
        audioSource.PlayOneShot(sSound);
    }

    public void tSoundPlay()
    {
        audioSource.PlayOneShot(tSound);
    }

    public void dSoundPlay()
    {
        audioSource.PlayOneShot(dSound);
    }

    public void eSoundPlay()
    {
        audioSource.PlayOneShot(eSound);
    }

    public void shSoundPlay()
    {
        audioSource.PlayOneShot(shSound);
    }

    public void CongratulationsSoundPlay()
    {
        audioSource.PlayOneShot(congratdSound);
    }
}
