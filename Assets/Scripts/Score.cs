using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;

    int score = 0;
    public void AddScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
    public void LostPoint()
    {
        if (score > 0)
        {
            score--;
            scoreText.text = "Score: " + score;
        }
        else
        {
            score = 0;
            scoreText.text = "Score: " + score;
        }
    }
}
