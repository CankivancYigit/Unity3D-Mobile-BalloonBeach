using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScoreText;
    int score = 0;
    int highScore;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("highscore");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        highScoreText.text = highScore.ToString();
        if (score>highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("highscore", score);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ScoreUp")
        {
            score++;
        }
    }
}
