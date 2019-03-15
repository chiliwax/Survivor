using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void EntryToLeft()
    {
        SceneManager.LoadScene("EntryLeft");
        inventory.scene = "EntryLeft";
    }
    public void EntryToRight()
    {
        SceneManager.LoadScene("EntryRight");
        inventory.scene = "EntryRight";
    }
    public void EntryManor()
    {
        SceneManager.LoadScene("Manor_entrance");
        inventory.scene = "EntryRight";
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Shadow");
            Debug.Log("swap");
        }
    }
}
