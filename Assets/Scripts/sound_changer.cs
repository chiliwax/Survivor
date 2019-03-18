using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_changer : MonoBehaviour
{
    public AudioClip _audioclip;
    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.FindGameObjectWithTag("sound").GetComponent<sound_launcher>().GetComponent<AudioClip>() == _audioclip) return;
        GameObject.FindGameObjectWithTag("sound").GetComponent<sound_launcher>().ChangeSound(_audioclip);
        GameObject.FindGameObjectWithTag("sound").GetComponent<sound_launcher>().PlayMusic();
    }
}
