using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterObject : MonoBehaviour
{
    [HideInInspector]
    public SpriteRenderer ObjectRenderer = null;
    // Start is called before the first frame update
    void Start()
    {
        ObjectRenderer = GetComponent<SpriteRenderer>();
    }

    public void Enter()
    {
        ObjectRenderer.color = Color.red;
    }
    public void Exit()
    {
        ObjectRenderer.color = Color.white;
    }
}
