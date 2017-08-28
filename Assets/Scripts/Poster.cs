using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    public AudioSource SCR1;
    public AudioSource SCR2;
    public AudioSource SCR3;
    public Camera_Activate CAMER;
    public int SCRwhich;
    public int IsOn;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        IsOn = CAMER.CameraFrame;
    }
    void SCR1init()
    {
        if (SCRwhich == 1)
        {
            SCR1.Play();
        }
    }
    void SCR2init()
    {
        if (SCRwhich == 2)
        {
            SCR2.Play();
        }
    }
    void SCR3init()
    {
        if (SCRwhich == 3)
        {
            SCR3.Play();
        }
    }
    public void Clicked()
    {
        if (2 > IsOn) {
        SCRwhich = Random.Range(1, 4);
        SCR1init();
        SCR2init();
        SCR3init();
        }
    }
}