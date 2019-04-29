using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreValue;
    public int highScore;
    // Start is called before the first frame update
    void Start()
    {
        score=PlayerPrefs.GetInt("Score", 0);
        highScore = PlayerPrefs.GetInt("HighScore", 500);
        PlayerPrefs.GetInt("Bounty");
    }

    // Update is called once per frame
    void Update()
    {
        scoreValue.text = "Score: " + score.ToString();
        PlayerPrefs.SetInt("Score", score);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
