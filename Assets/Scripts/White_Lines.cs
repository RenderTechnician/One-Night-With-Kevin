using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class White_Lines : MonoBehaviour
{
    public Sprite[] WLS;
    public int Flipper;
    public SpriteRenderer FlipSR;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int SpriteIndex = Flipper;
        this.GetComponent<SpriteRenderer>().sprite = WLS[SpriteIndex];
        UpCount();
        Stall();
    }
    void UpCount()
    {
        if (Flipper > 0)
        {
            Flipper++;
            FlipSR.enabled = true;
        }
    }
    void Stall()
    {
        if (Flipper > 7)
        {
            Flipper = 0;
            FlipSR.enabled = false;
        }
    }
    public void Initiate()
    {
        Flipper++;
    }
}