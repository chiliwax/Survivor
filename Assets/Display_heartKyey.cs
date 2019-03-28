using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Display_heartKyey : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
          if (inventory.gold_key)
        {
           GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        } 
    }
}
