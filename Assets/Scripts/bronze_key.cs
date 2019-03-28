using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bronze_key : MonoBehaviour
{
    public GameObject _game;
    public GameObject _obj;
    public Sprite _sprite;
    public AudioSource sound_source;
    public AudioClip sound_clip;
    // Start is called before the first frame update
    void Start()
    {
        if (inventory.bronze_key == false) {
            StartCoroutine(DelayBeforePlay());
        }
        else
        {
            _game.SetActive(false);
            _obj.GetComponent<SpriteRenderer>().sprite = _sprite;
        }
    }
    IEnumerator DelayBeforePlay()
    {
        yield return new WaitForSeconds(3f);
        sound_source.PlayOneShot(sound_clip);
    }
}
