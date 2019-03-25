using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class skipVid : MonoBehaviour
{
    public VideoPlayer _cam;
    public string _scene;
    private bool _flag = true;

    // Start is called before the first frame update
    void Start()
    { 
       _cam.EnableAudioTrack(0, false); 
    }

    // Update is called once per frame
    void Update()
    {
        if (_cam.isPlaying == false && _flag)
        {
                _flag = !_flag;
            StartCoroutine(LoadSceneAsync());
                SceneManager.LoadScene(_scene);
                inventory.scene = _scene;
        }
    }
    IEnumerator LoadSceneAsync()
    {
        yield return new WaitForSeconds(3);
        AsyncOperation async = SceneManager.LoadSceneAsync(_scene);
        while (!async.isDone)
        {
            yield return null;
        }
    }
}
