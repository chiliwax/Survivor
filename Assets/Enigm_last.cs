using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enigm_last : MonoBehaviour
{
    public GameObject _Phone;

    // Start is called before the first frame update
    void Start()
    {
        if (inventory.silver_key == true)
        {
            _Phone.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
