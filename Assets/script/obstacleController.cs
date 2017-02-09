using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour {

    public float scrollSpeed = 5.0f;
    public GameObject[] obstacle;
    public float timeBetweenObstacle = 0.5f;
    public float counter = 0.0f;
    public Transform obstaclesSpawnPosition;

    playerController player;
    public gameController theGameCtrl;
    Collision2D other;

    public float speedMultiplier;
    public float speedIncrease;
    private float speedCounter;

    // Use this for initialization
    void Start()
    {
        RandomizeObstacle();
    }

    // Update is called once per frame
    void Update()
    {
       /* if (other.gameObject.tag == "killbox")
        {
            theGameCtrl.gameOver();
            return;
        } */

        //Generate new object
        if (counter <= 0.0f)
        {
            RandomizeObstacle();
        }
        else
        {
            counter -= Time.deltaTime * timeBetweenObstacle;

        }

        //scrolling obstacle towards you
        GameObject currentChild;
        for (int i = 0; i < transform.childCount; i++) //all obstacle are children of the controller
        {
            currentChild = transform.GetChild(i).gameObject;
            ScrollObstacle(currentChild);
            if(currentChild.transform.position.x <= -15.0f)
            {
                Destroy(currentChild);
            }

            if (currentChild.transform.position.x > speedCounter) //making the game go faster every time counter > 45
            {
                speedCounter += speedIncrease;
                speedIncrease = speedIncrease * speedMultiplier;
                scrollSpeed = scrollSpeed * speedMultiplier;
                //timeBetweenObstacle = timeBetweenObstacle - 0.05f;
            }
        }
    }

    //move the obstacle towards you
    void ScrollObstacle(GameObject currentObstacle)
    {

        currentObstacle.transform.position -= Vector3.right * (scrollSpeed * Time.deltaTime);

    }
    //random between the different obstacle
    void RandomizeObstacle()
    {
        GameObject newObstacle = Instantiate(obstacle[Random.Range(0, obstacle.Length)], obstaclesSpawnPosition.position, Quaternion.identity) as GameObject;
        newObstacle.transform.parent = transform;
        counter = 1.0f;
    }

}
