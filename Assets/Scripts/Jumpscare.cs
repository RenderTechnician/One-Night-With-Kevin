using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour {
    public SpriteRenderer JumpSprite;
    public Cams Cam_BridgeII;
    public int BridgeBridge;
    public AudioSource ASJ;
    public Sprite[] Holdme;
    public int HoldMeCount;
    public int Screamcount;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BridgeBridge = Cam_BridgeII.Kev_Mov;
        
        Enabler();
        NextFrame();

        int SpriteIndex = HoldMeCount;
        this.GetComponent<SpriteRenderer>().sprite = Holdme[SpriteIndex];
    }
    void Enabler()
    {
        if (BridgeBridge > 9)
        {
            HoldMeCount++;
            JumpSprite.enabled = true;
           
            Screamer();
            Screamcount++;
        }

    }
    void NextFrame()
    {
        if(HoldMeCount > 9)
        {
            Application.LoadLevel("Loss");
            print("FuckItAll");
        }
        
    }
    void Screamer()
    {
        if (!ASJ.isPlaying)
        {
            ASJ.Play();

        }
    }
}
