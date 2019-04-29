using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Displayscore : MonoBehaviour
{
    public Text highscoreText;
    public Text scoreText;
    public int score;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        score = PlayerPrefs.GetInt("Score", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 500);
    }

    // Update is called once per frame
    void Update()
    {
        highscoreText.text = "HighScore: " + highScore.ToString();
        scoreText.text = "Score: " + score.ToString();
    }
}
