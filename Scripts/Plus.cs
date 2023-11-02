using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{
    public Text ScoreText;

    public static int score = 0;

    public Text highscoreText;

    int highscore = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore", 0);
        score = 0;
    }

    public void AddScore(int newScore)
    {
        score += newScore;

        if (highscore < score)
        PlayerPrefs.SetInt("highscore", score);
    }

    public void UpdateScore()
    {
        ScoreText.text = "Score 0" + score;
    }
    // Update is called once per frame
    void Update()
    {
        UpdateScore();

    }

}