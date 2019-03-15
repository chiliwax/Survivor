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
        float transparency = ObjectRenderer.color.a;
        ObjectRenderer.color = new Color(Color.red.r, Color.red.g, Color.red.b, transparency);
    }
    public void Exit()
    {
        float transparency = ObjectRenderer.color.a;
        ObjectRenderer.color = new Color(Color.white.r, Color.white.g, Color.white.b, transparency);
    }
}
