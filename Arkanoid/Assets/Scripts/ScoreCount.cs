using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public int currentScore = 0;
    public Text scoreText;
    public Text highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
        highScoreText.text = PlayerPrefs.GetInt("highScore", 0).ToString();
    }

    public void ChangeBy (int changeAmount)
    {
        currentScore++;
        scoreText.text = currentScore.ToString();
        if(currentScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", currentScore);
            highScoreText.text = currentScore.ToString();
        }
    }
}
