using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle_1_painting : MonoBehaviour
{
    public int _col = 1;
    private int _raw = 0;
    public GameObject Prefab_Container;
    public Sprite[] Puzzle;
    private int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 _pos = new Vector2(0,0);
        foreach(Sprite _sprite in Puzzle){
           GameObject tmp = Instantiate(Prefab_Container, this.transform);
           Vector3 location = tmp.transform.localPosition;
            location.x = count * tmp.GetComponent<SpriteRenderer>().size.x;
            location.y = (_raw * tmp.GetComponent<SpriteRenderer>().size.y) * -1;
            tmp.GetComponent<SpriteRenderer>().sprite = _sprite;
            tmp.transform.localPosition = location;
            count++;
           if (count == _col) {
               _raw++;
               count = 0;
           }
           
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
