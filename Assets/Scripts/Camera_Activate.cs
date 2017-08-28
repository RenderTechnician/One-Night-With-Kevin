using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera_Activate : MonoBehaviour
{
    public int CameraFrame;
    public int Cam_AC = 0;
    public Sprite[] Cams;
    public Power Powerinput;
    public int PowerBridge;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        cannit2();
        cannit3();
        PowerBridge = Powerinput.Powers;
        if (Cam_AC == 0)
        {
            upcount();
        }
        if (Cam_AC == 1)
        {
            downcount();
        }
        if (Cam_AC >= 2)
        {
            Cam_AC = 0;
        }
        int spriteIndex = CameraFrame;
        this.GetComponent<SpriteRenderer>().sprite = Cams[spriteIndex];

    }
    void upcount()
    {
        if (CameraFrame < 9)
        {
            CameraFrame++;
        }
    }
    void downcount()
    {
        if (CameraFrame > 1)
        {
            CameraFrame--;
        }
    }
    void cannit3()
    {
        if (1 > PowerBridge)
        {
            Cam_AC = 1;
            CameraFrame = 0;
        }
    }
    void cannit2()
    {
        if (PowerBridge > 0)
        {
            Caminit();
        }
    }
    void Caminit()
    {
        
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                GetComponent<AudioSource>().Play();
            Cam_AC++;

        }
    }
}


