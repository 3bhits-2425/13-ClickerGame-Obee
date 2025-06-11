using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreSystem : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }
    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
    public void SaveScore()
    {
        PlayerPrefs.SetInt("PlayerScore", score);
    }
    public void LoadScore()
    {
        score = PlayerPrefs.GetInt("PlayerScore", 0);
        UpdateScoreText();
    }
}
