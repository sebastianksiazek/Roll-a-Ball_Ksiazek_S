using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public GameObject player;
    public Text scoreText;
    public Text koniecgry;

    private void Start()
    {
        GameManager.Instance.OnScoreChanged += UpdateScoreText;
        GameManager.Instance.OnGameEnd += DisplayGameEndMessage;
    }

    private void UpdateScoreText(int score)
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    private void DisplayGameEndMessage()
    {
        if (koniecgry != null)
        {
            koniecgry.text = "Koniec Gry!";
        }
    }
}

