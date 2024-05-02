using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TextMeshProUGUI scoreText;

    private int trashValue = 5;

    public static int score = 0;
    public static int highscore = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = "Puan  " + score.ToString();
    }

    public void AddPoint()
    {
        score += trashValue;
        scoreText.text = "Puan  " + score.ToString();
    }

    
}
