using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Toggle : MonoBehaviour {
    public Renderer ContTog;

    public int SPCT;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(SPCT > 1)
        {
            SPCT = 0;
        }
        if(SPCT == 1)
        {
            ContTog.enabled = true;
        
        }
        else
        {
            ContTog.enabled = false;
        }
	}
    public void Counts()
    {
        SPCT++;
    }
}
