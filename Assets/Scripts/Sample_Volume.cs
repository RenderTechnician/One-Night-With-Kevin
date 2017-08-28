using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Sample_Volume : MonoBehaviour {
    public Camera_Activate Cams;
    public int IsOn;
    public AudioSource Fan;
    public AudioSource Buzz;
    public AudioSource Donate;
    // Use this for initialization
    void Start () {
	}
    void Vol()
    {
        if (IsOn == 1) {
            Donate.volume = 0.05f;
            Fan.volume = 1.0f;
            Buzz.volume = 0.1f;
        }
        else
        {
            Donate.volume = 0.5f;
            Fan.volume = 0.4f;
            Buzz.volume = 0.05f;
        }
    }
	// Update is called once per frame
	void Update () {
        IsOn = Cams.Cam_AC;
        Vol();
       
    }
}
