using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitBeforeSound : MonoBehaviour
{

    public float SleepTime = 3.0f;
    private AudioSource _audio;
    void Start()
    {
        _audio = GetComponent<AudioSource>();
        StartCoroutine(Play());
    }

    IEnumerator Play()
    {
        yield return new WaitForSeconds(SleepTime);
        _audio.Play();
    }
}
