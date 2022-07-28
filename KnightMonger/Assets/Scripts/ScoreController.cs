using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
    public Text menuScoreTextGameOver;
    public Text bestScoreTextGameOver;
    public Text menuScoreTextEnd;
    public Text bestScoreTextEnd;
    private static int score;
    private static int bestScore = 0;
    private int resetScore = 0;
    private bool isReset = false;

    void Start()
    {
        bestScore = PlayerPrefs.GetInt("BestScore");
        score = 0;
    }

   
    void Update()
    {
        setBestScore();   
        menuScoreTextGameOver.text = "Your score: " + score.ToString();
        menuScoreTextEnd.text = "Your score: " + score.ToString();
        bestScoreTextGameOver.text = "Best score: " + bestScore.ToString();
        bestScoreTextEnd.text = "Best score: " + bestScore.ToString();
        scoreText.text = "Score: " + score.ToString();
    }

    public void addScore(int points)
    {
        score += points;
        Debug.Log("score" + score);
    }

    public void setBestScore() 
    {
        if (score > bestScore)
        {
            PlayerPrefs.SetInt("BestScore", score);
            bestScore = score;
        }
    }

    public void ResetBestScore()
    {
        PlayerPrefs.SetInt("BestScore", resetScore);
        score = resetScore;
        bestScore = resetScore;
    }

}

