using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPhone1 : MonoBehaviour
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
        if (inventory.Phone1 == false)
            _audio.Play();
        inventory.Phone1 = true;
    }
}
