using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Use TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    public TextMeshPro scoreText; // Reference to the TextMeshProUGUI component
    private int score = 0;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
