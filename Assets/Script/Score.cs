using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score instance;
    public Text scoreTxt;
    public int scoreAmount;
    
    void Start()
    {
        if(instance == this) {
           instance = this;
        }

        scoreAmount = 0;    
    }

    public void IncrementScore() {
        scoreAmount += 5;
        scoreTxt.text = scoreAmount.ToString(); 
    }
}
