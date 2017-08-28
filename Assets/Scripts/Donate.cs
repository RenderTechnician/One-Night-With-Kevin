using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Donate : MonoBehaviour {
    public Image IMG;
    public Text Donater;
    public Text Bill;
    public Text Billment;
    public int CameraFrame3;
    public Camera_Activate CamAcc;
    // Use this for initialization
    void Start() {

    }
    void RenderState()
    {
        CameraFrame3 = CamAcc.CameraFrame;
        if (CameraFrame3 > 8)
        {

            GameObject.Find("Button").GetComponent<Button>().enabled = true;
            IMG.enabled = true;
            Donater.enabled = true;
            Bill.enabled = true;
            Billment.enabled = true;
        }
        else
        {

            GameObject.Find("Button").GetComponent<Button>().enabled = false;
            IMG.enabled = false;
            Donater.enabled = false;
            Bill.enabled = false;
            Billment.enabled = false;


            }
        }
    // Update is called once per frame
    void Update()
    {
        RenderState();
    }
}