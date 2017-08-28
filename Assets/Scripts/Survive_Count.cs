using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Survive_Count : MonoBehaviour {
    private int mindyourownbusiness;
    private int Over6;
    public SpriteRenderer SP2;
    public AudioSource Listen;
    public AudioSource Listen2;
    public Text text;
    public SpriteRenderer SP3;
    // Use this for initialization
    void Start () {
		
	}
     void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
    // Update is called once per frame
    void Update () {
        mindyourownbusiness++;
        if (mindyourownbusiness > 360)
        {
            SP2.enabled = false;
            Listen.enabled = false;
            Listen2.enabled = false;
            text.enabled = false;
            SP3.enabled = true;
        }
        else
        {
            SP3.enabled = false;
        }
        if(mindyourownbusiness > 480)
        {
            LoadNextLevel();
        }
	}

}
