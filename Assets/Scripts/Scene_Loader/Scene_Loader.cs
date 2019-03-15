using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Loader : MonoBehaviour
{
    public void EntryToLeft()
    {
        SceneManager.LoadScene("EntryLeft");
    }
    public void EntryToRight()
    {
        SceneManager.LoadScene("EntryRight");
    }
}
