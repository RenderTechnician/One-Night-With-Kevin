using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bill : MonoBehaviour {
    public int Credit;
    public Text text;
	// Use this for initialization
	void Start () {
		
	}
	public void AddToBill()
    {
        Credit = Credit + Random.Range(2, 15);
       
    }
    // Update is called once per frame
    void Update() {
        text.text = "£ " + Credit.ToString();
        PlayerPrefs.SetInt("MoneyUsed", Credit);
	}
}
