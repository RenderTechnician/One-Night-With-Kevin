using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    public int Frame;
    public Sprite[] spriteOffice;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        renegade();
        Frame++;
        int spriteIndex = Frame;
        this.GetComponent<SpriteRenderer>().sprite = spriteOffice[spriteIndex];
    }
    void renegade()
    {
        if (Frame > 2)
        {
            Frame = 0;
        }

    }
}
