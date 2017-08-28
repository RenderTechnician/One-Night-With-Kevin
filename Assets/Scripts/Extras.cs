using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extras : MonoBehaviour
{
    public int Devimgcount;
    public int WhichCount;
    public Sprite[] Spriter;
    public Sprite[] Spriter2;
    //SP6 = Making of images visibility
    public SpriteRenderer SP6;
    //SP7 = Dev1 visibility
    public SpriteRenderer SP7;
    //Left Arrow Visibility
    public SpriteRenderer SP8;
    //Right Arrow Visibility
    public SpriteRenderer SP9;
    public SpriteRenderer SP10;
    public int MaxDI;
    public int MinDI;
    // Use this for initialization
    void awake()
    {
        ImageStack();
    }

    // Update is called once per frame
    void Update()
    {
        if (WhichCount == 1)
        {
            int spriteIndex = Devimgcount;
            this.GetComponent<SpriteRenderer>().sprite = Spriter[spriteIndex];
        }
        if (WhichCount == 2)
        {
            int spriteIndex = Devimgcount;
            this.GetComponent<SpriteRenderer>().sprite = Spriter2[spriteIndex];
        }
    }
    void ImageStack()
    {
        if (WhichCount == 1)
        {

            SP6.enabled = false;
            SP7.enabled = true;
            SP8.enabled = true;
            SP9.enabled = true;
        }
        if (WhichCount == 2)
        {
            SP6.enabled = true;
            SP7.enabled = false;
            SP8.enabled = false;
            SP9.enabled = false;
        }
        if (WhichCount == 0)
        {
            SP6.enabled = false;
            SP7.enabled = false;
            SP8.enabled = false;
            SP9.enabled = false;
        }
    }
    public void DevImages()
    {

        SP10.enabled = false;
        WhichCount = 1;
        Devimgcount = 0;
        ImageStack();  
    }
    public void MakingOf()
    {

        SP10.enabled = false;
        WhichCount = 2;
        Devimgcount = 0;
        ImageStack();
    }
    public void INCCOUNT()
    {
        if (MaxDI >= Devimgcount)
        {
            Devimgcount++;
            print(Devimgcount);
            ImageStack();
        }
    }
    public void DOWNCCOUNT()
    {
        if (Devimgcount >= MinDI)
        {
            Devimgcount--;
            print(Devimgcount);
            ImageStack();
        }

    }

}