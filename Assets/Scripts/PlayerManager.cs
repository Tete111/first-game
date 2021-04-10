﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;
    public static bool isGameStarted;
    public GameObject startingText;
    public static int numberOfCoins;
    public Text coinsText;
    public Text scoreText;
    public Text highscoreText;
    public static int numberOfScore;
    public static int numberOfhsScore;
    void Start()
    {
        PlayerPrefs.GetInt("highScore");
        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
        numberOfCoins = 0;
        numberOfScore = 0; 
    }

    // Update is called once per frame
    void Update()
    {
      //if (numberOfScore > PlayerPrefs.GetInt ("highScore"))
      //PlayerPrefs.SetInt ("highScore", numberOfScore);
        if(gameOver)
        {   
            PlayerPrefs.SetInt ("highScore", numberOfhsScore);
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }

        coinsText.text = "Coins: " + numberOfCoins;
        scoreText.text = "Score: " + numberOfScore;
        highscoreText.text = "HighScore: " + numberOfhsScore;

        if(!gameOver)
        if(isGameStarted)
        {
            numberOfScore += 1;
        }

        if (SwipeManager.tap)
        {
            isGameStarted = true;
            Destroy(startingText);
            
        }
    }
}
