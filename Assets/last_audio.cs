using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class last_audio : MonoBehaviour
{
    private AudioSource _audio;
    private bool flag = false;
    // Start is called before the first frame update
    public void Play()
    {
        _audio = GetComponent<AudioSource>();
        _audio.Play();
        flag = true;
    }
    
    void Update()
    {
        if (!_audio.isPlaying && flag == true) {
            inventory.Phone1 = false;
            inventory.Phone2 = false;
            inventory.Phone3 = false;
            inventory.bronze_key = false;
            inventory.gold_key = false;
            inventory.silver_key = false;
            SceneManager.LoadScene("Intro");
            
        }
    }

}
