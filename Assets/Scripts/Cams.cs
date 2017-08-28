using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cams : MonoBehaviour {
    public Sprite[] Which;
    public int Prog;
    public int CameraFrame2;
    public Camera_Activate CamAcc;
    private int Cam_Bridge;
    public Renderer Rend;
    public int Trans_Pog;
    public int Kev_Mov;
    public int Clock;
    public int Statcount;
    public SpriteRenderer Static;
    public int Clock3;

    // Use this for initialization

    //Cam Programatics
    //Cam01
    void KEV1()
    {
        if (Kev_Mov == Trans_Pog)
        {
            Prog = (Trans_Pog + 4);  
        }
        else
        {
            Prog = Trans_Pog;
        }
    }
    //Clock Reset
    void ClockReset()
    {
        Clock++;
        //Resets clock if it goes above 600/time
        if (Clock > 600)
        {
            Clock = 0;
            Clock3++;
        }   
    }
    public void CAM01INIT()
    {
        GetComponent<AudioSource>().Play();
        print(Prog);
        Trans_Pog = 0;
        Prog = Trans_Pog;

    }
    //Cam02
    public void CAM02INIT()
    {
        
        GetComponent<AudioSource>().Play();
        print(Prog);
        Trans_Pog = 1;
        Prog = Trans_Pog;
    }
    //Cam03
    public void CAM03INIT()
    {

        GetComponent<AudioSource>().Play();
        print(Prog);
        Trans_Pog = 2;
        Prog = Trans_Pog;
    }
    //Cam04
    public void CAM04INIT()
    {

        GetComponent<AudioSource>().Play();
        print(Prog);
        Trans_Pog = 3;
        Prog = Trans_Pog;
    }
    void Start() {
    }
    // Update is called once per frame
    void Update() {
        RenderState();
        KEV1();
        ClockReset();
        statics();
        StatReset();
        if (Clock > 3600 / Clock3)
        {
            Clock = 0;
            Kev_Mov++;
            Statcount++;
        }
    }
    void RenderState()
    {
        CameraFrame2 = CamAcc.CameraFrame;
        if (CameraFrame2 > 8)
        {
            Rend.enabled = true;
      
        }
        else
        {
            Rend.enabled = false;
         

        }
        
    }
    public void MoveKev()
    {
        Kev_Mov = Trans_Pog;
            Statcount++;
    }
    void statics ()
    {
    if (Statcount > 0)
        {
            Statcount++;
            Statics2();
        }

    }
    void Statics2()
    {
        if (CameraFrame2 > 1)
        {
            Static.enabled = true;
        }
    }
    void StatReset()
    {
        if (Statcount > 30)
        {
            Static.enabled = false;
            Statcount = 0;
        }
    }
    void FixedUpdate()
    {
        int spriteIndex2 = Prog;
        this.GetComponent<SpriteRenderer>().sprite = Which[spriteIndex2];
        if (Kev_Mov == 4)
        {
            Kev_Mov = 10;
        }
    }
}