using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class listController : MonoBehaviour {

    public Text[] highScores;
    int[] highScoreValues;
    string[] highScoreNames;

	// Use this for initialization
	void Start () {

        highScoreValues = new int[highScores.Length]; // Limiting the scoreboard
        highScoreNames = new string[highScoreNames.Length];

        for (int x = 0; x < highScores.Length; x++)
        {
            highScoreValues[x] = PlayerPrefs.GetInt("highScoreValues" + x); //highScoreValues 0, 1, 2 etc
            highScoreNames[x] = PlayerPrefs.GetString("highScoreNames" + x); 
        }
        drawScores();
	}

    void saveScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            PlayerPrefs.SetInt("highScoreValues" + x, highScoreValues[x]);
            PlayerPrefs.SetString("highScoreNames" + x, highScoreNames[x]);
        }
    }

    public void checkForHighScore(int _value, string _userName)
    {
        for(int x = 0; x < highScores.Length; x++) //showing the last number down
        {
            if(_value > highScoreValues [x])
            {
                for(int j = highScores.Length -1; j > x; j--)
                {
                    highScoreValues[j] = highScoreValues[j - 1];
                    highScoreNames[j] = highScoreNames[j - 1];
                }
                highScoreValues[x] = _value;
                highScoreNames[x] = _userName;
                drawScores();
                saveScores();
                break;
            }
        }
    }

    void drawScores()
    {
        for (int x = 0; x < highScores.Length; x++)
        {
            highScores [x].text = highScoreNames [x] + ":" + highScoreValues [x].ToString(); // draw values to the screen
        }
    }

    void Update()
    {

    }

}
