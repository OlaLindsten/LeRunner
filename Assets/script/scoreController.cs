using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreController : MonoBehaviour {

    public Text score;
    public Text highScore;
    public Text score2;
    public Text highScore2;

    public float scoreCounter;
    public float highScoreCounter;
    public float points;
    public bool scoreInc;

    void Start()
    {
        if(PlayerPrefs.HasKey("HighScore"))
        {
            highScoreCounter = PlayerPrefs.GetFloat("HighScore");
        }
    }

	// Update is called once per frame
	void Update () {

        if (scoreInc)
        {
            scoreCounter += points * Time.deltaTime;
        }

        if(scoreCounter > highScoreCounter)
        {
            highScoreCounter = scoreCounter;
            PlayerPrefs.SetFloat("HighScore", highScoreCounter);
        }

        score.text = "Score: " + Mathf.RoundToInt (scoreCounter);
        highScore.text = "HighScore " + Mathf.RoundToInt(highScoreCounter);

        score2.text = "Score: " + Mathf.RoundToInt(scoreCounter);
        highScore2.text = "HighScore " + Mathf.RoundToInt(highScoreCounter);
    }
}
