using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enigm2luncher : MonoBehaviour
{
    public Sprite _phoneBG;
    public GameObject _BG;
    public GameObject _Phone;

    // Start is called before the first frame update
    void Start()
    {
        if (inventory.bronze_key == true)
        {
            _BG.GetComponent<SpriteRenderer>().sprite = _phoneBG;
            _Phone.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
