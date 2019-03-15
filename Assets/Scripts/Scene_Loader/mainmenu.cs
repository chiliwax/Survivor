using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainmenu : MonoBehaviour
{
 public void Mainmenu () 
    {
        SceneManager.LoadScene("Shadow");
        //SceneManager.LoadScene("Shadow", LoadSceneMode.Additive);
    }
}
