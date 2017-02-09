using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonController : MonoBehaviour {

    private scoreController theScoreController;

    void start()
    {
        theScoreController = FindObjectOfType<scoreController>();
        theScoreController.scoreInc = true;
    }

    public void newGameBtn(string newGame)
    {
        SceneManager.LoadScene(newGame); //load and restart the game
    }

    public void exitGameBtn()
    {
        Application.Quit(); //quit the game button
    }

    public void mainMenu(string start)
    {
        SceneManager.LoadScene(start); //quit to main menu
    }

   /* public void getInput(string name)
    {
        Debug.Log("Username " + name);
    } */
}
