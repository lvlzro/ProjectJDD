﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text text;
    private void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }
    private void Update()
    {
        text.text = "Score: " + score;
      
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
        PlayerPrefs.SetInt("HighScore", score);//works
        }


    }
}
