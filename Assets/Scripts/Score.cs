using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour {
    public  int Bill1;
    public Bill billbridge;
    public int Scores;
    public Text SCR;
    public Text Used;
    public int MoneyUsed;

    // Use this for initialization
    void Start () {
       MoneyUsed = PlayerPrefs.GetInt("MoneyUsed");
    }
	
	// Update is called once per frame
	void Update () {
        SCR.text = "£ " + Scores.ToString();
        Used.text = "£ " + MoneyUsed.ToString();
        Bill1 = MoneyUsed;
        Scores = 500 - Bill1;
	}
}
