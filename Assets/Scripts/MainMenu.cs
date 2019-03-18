using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(inventory.scene);
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit !");
        Application.Quit();
        Debug.Log("bronze : " + inventory.bronze_key.ToString());
        Debug.Log("silver : " + inventory.silver_key.ToString());
        Debug.Log("gold : " + inventory.gold_key.ToString());
    }
}
