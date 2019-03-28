using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterObject : MonoBehaviour
{
    //[HideInInspector]
    public SpriteRenderer ObjectRenderer = null;
    //[HideInInspector]
    public MeshRenderer ObjectRenderer3D = null;
    // Start is called before the first frame update
    void Start()
    {
        if (!ObjectRenderer)
        ObjectRenderer = GetComponent<SpriteRenderer>();
        if (!ObjectRenderer3D)
        ObjectRenderer3D = GetComponent<MeshRenderer>();
    }

    public void Enter()
    {
        Debug.Log("enter");
        if (ObjectRenderer) {
        float transparency = ObjectRenderer.color.a;
        ObjectRenderer.color = new Color(Color.red.r, Color.red.g, Color.red.b, transparency);
        }
        else {
            float transparency = ObjectRenderer3D.material.color.a;
            ObjectRenderer3D.material.color = new Color(Color.red.r, Color.red.g, Color.red.b, transparency);
        }
    }
    public void Exit()
    {
        if (ObjectRenderer) {
        float transparency = ObjectRenderer.color.a;
        ObjectRenderer.color = new Color(Color.white.r, Color.white.g, Color.white.b, transparency);
        }
        else {
            float transparency = ObjectRenderer3D.material.color.a;
            ObjectRenderer3D.material.color = new Color(Color.white.r, Color.white.g, Color.white.b, transparency);    
        }
    }
}
