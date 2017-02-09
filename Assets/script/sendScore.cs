using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sendScore : MonoBehaviour {

    public InputField playerName;
    private scoreController theScoreController;

    // Use this for initialization
    void Start () {

    }

    // Update is called once per frame
    void Update () {
		
	}


    /*public void sendHighScore()
    {
        float scoreingame;
        scoreingame = scoreController.scoreCounter;
        int xd = System.Convert.ToInt32(scoreingame);
        Debug.Log("score vi skickar in " + xd);

        Debug.Log("namn vi får: " + playerName);

        GetComponent<listController>().checkForHighScore(xd, playerName.text);
        Debug.Log("namn vi får: " + playerName);
    } */
}
