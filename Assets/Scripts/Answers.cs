using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Answers 
{
    [TextArea(3,5)]
   public string answer;
   public Color color = Color.black;
   public GameObject action = null;
}
