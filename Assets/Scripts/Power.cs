using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Power : MonoBehaviour {
    //Power Display
    public Text Powerdisp;
    public int Powers;
    public Camera_Activate PowerCA;
    public int PowerCATrans;
    public int Relay;
    public int GradualDrain;
    public SpriteRenderer Poweron;
    public SpriteRenderer Poweroff;
    public AudioSource loss;
    public AudioSource fanner;
    public AudioSource buzzer2;
    public Text Text1;
    public Text Text2;
    public Text Text3;

    // Use this for initialization
    void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        GradualDrain++;
        OutOfPower();
        PowerLower();
        GradDran();
        PowerCATrans = PowerCA.CameraFrame;
        Powerdisp.text = "Power : " + Powers.ToString() + " %";
        if (PowerCATrans > 1)
        {
            Relay++;
        }
	}
    void PowerLower()
    {
        if (Relay > 90)
        {
            Powers--;
            Relay = 0;
        }
        
    }
    void GradDran()
    {
        if (GradualDrain > 5)
        {
          
            Relay++;
            GradualDrain = 0;
        }
    }
    void OutOfPower()
    {
        if (1 > Powers)
        {
            Poweron.enabled = false;
            Poweroff.enabled = true;
            Text1.enabled = false;
            Text2.enabled = false;
            Text3.enabled = false;
            buzzer2.enabled = false;
            fanner.enabled = false;
            loss.Play();

        }
    }
}
