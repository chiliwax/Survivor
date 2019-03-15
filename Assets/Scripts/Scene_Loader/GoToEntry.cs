using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToEntry : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene()
    {
     SceneManager.LoadScene("Manor_entrance");   
    }
}
