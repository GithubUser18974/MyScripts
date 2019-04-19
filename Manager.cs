using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {
    public Text score;
    public Text timer;
  
    public int scoreIncrement = 1;
    public float maxMN = 0f;
    public float maxHR = 0f;
    public float maxSC = 0f;
    public float maxScore = 20.0f;
    private   int mn=0, hr=0, sc=0;
    public  static int scoreint=0;
    
    // Use this for initialization
    void Start () {
        score.text = "0";
        timer.text = "0:0:0";
        hr = 0;
        sc = 0;
        mn = 0;
       

	}
	
	// Update is called once per frame
	void Update () {

        ///////////////////////////////////////timer
        sc++;
        if (sc >= 60)
        {
            mn++;
            sc = 0;

        }
        if (mn >= 60)
        {
            hr++;
            sc = 0;
        }
        timer.text = hr + ":" + mn + ":" + sc;

        //////////////////////////////////////
        if (scoreint >= maxScore)
        {
            timer.text = "You Done";
        }
        if (mn >= maxMN && sc >= maxSC && hr >= maxHR)
        {
            timer.text = "GAme Over";
        }
        ////////////////////////////////////// score
        score.text ="Score: "+ scoreint.ToString();
        //////////////////////////////////////
       

    }
    public void  setScore(int sc)
    {
       
        if (sc==1)
        scoreint += scoreIncrement;

        score.text = scoreint.ToString();
        Debug.Log("Score"+scoreint);
    }
  
}
