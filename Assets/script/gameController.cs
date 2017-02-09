using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameController : MonoBehaviour
{

    public GameObject gameOverPanel;
    private scoreController theScoreController;
    //public static string inGameName;

    void start()
    {
        theScoreController = FindObjectOfType<scoreController>();
    }

    public void gameOver()
    {
        gameOverPanel.SetActive(true);
        Debug.Log("funkar?");
    }
}
 







/*public void sendHighScore()
    {
        /*GetComponent<buttonController> ().getInput(name);
        Debug.Log("namn23: " + name);

        float scoreingame;
        scoreingame = scoreController.scoreCounter;
        int xd = System.Convert.ToInt32(scoreingame);
        Debug.Log("score vi skickar in " + xd);
        GetComponent<listController> ().checkForHighScore(xd, name); 
       





        /*string ingameName;
        ingameName = playerName.text;
        Debug.Log("detta namnet skickar vi in: " + playerName);
        GetComponent<listController>().checkForHighScore(theScoreController.scoreCounter, ingameName);
        Debug.Log(theScoreController.scoreCounter);
        Debug.Log(playerName.text); 
    } */

