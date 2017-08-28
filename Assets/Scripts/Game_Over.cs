using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Over : MonoBehaviour {
    public int Timer;
    public SpriteRenderer SP1GO;
    public SpriteRenderer SP2GO;
    public AudioSource Stater;
    // Use this for initialization
    void Start () {
        Stater.Play();
	}
	
	// Update is called once per frame
	void Update () {
        Timer++;
        if (Timer > 300)
        {
            print("ohno");
            Stater.Stop();
            SP1GO.enabled = false;
            SP2GO.enabled = true;
        }
        if (Timer > 400)
        {
            Application.LoadLevel("Main Menu");
        }
	}
    void Awake()
    {
        SP1GO.enabled = true;
    }
    
}
