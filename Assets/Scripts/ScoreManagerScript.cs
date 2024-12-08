using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManagerScript : MonoBehaviour
{
    public int score = 0;

    public TextMeshProUGUI scoreText;

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "SCORE: " + score.ToString();
    }
}
