
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text ScoreText;
    public int score = 16;
    public void DecrementScore()
    {
        score--;
        ScoreText.text = "Score: " + score;
    }
}