using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Check_Phone3_ok : MonoBehaviour
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
      //  Debug.Log (inventory.bronze_key + "/" +  inventory.Phone2);
        
        if (inventory.Phone3 == true)
        {
            _audio.Play();
        }
    }
}
