using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class change_play_button : MonoBehaviour
{
    
    void Update()
    {
        if (inventory.scene != "Chiliwa")
        {
            TextMeshProUGUI mText = gameObject.GetComponent<TextMeshProUGUI>();
            mText.text = "Continue";
        }
        else
        {
            TextMeshProUGUI mText = gameObject.GetComponent<TextMeshProUGUI>();
            mText.text = "New Game";
        }
    }
}
