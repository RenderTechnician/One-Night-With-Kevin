using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour {
    public int Framec;
    public int Timec;
    public Text text;
    public void LoadNextLevel()
    {
        Application.LoadLevel(Application.loadedLevel+1);
    }
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Framec++;
        text.text = Timec.ToString() + " AM";
    }
    void FixedUpdate()
    {
        //12AM assignment
        if (Timec == 0)
        {
            Timec = 12;
        }
        if (Timec ==13)
        {
            Timec = 1;
        }
        if (Framec >= 3600)
        {
            Timec++;
            Framec = 0;
        }
        if (Timec == 6)
        {
            LoadNextLevel();


        }
    }
}
