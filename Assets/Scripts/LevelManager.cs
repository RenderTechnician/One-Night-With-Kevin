using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public void LoadLevel(string name)
        
    {
        Application.LoadLevel(name);
        
    }

    public void Quit()
    {
        Application.Quit();
    }

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
}
