using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public GameObject playerObject;
    public float jumpPower = 40.0f;
    public bool grounded;
    public LayerMask isGround;

    obstacleController obstacleCtrl;
    private scoreController theScoreController;

    private BoxCollider2D myCollider;
    private Rigidbody2D myRigidbody;
    private Animator myAnimator;
    private CircleCollider2D myCircleCollider;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();

        myCollider = GetComponent<BoxCollider2D>();

        myCircleCollider = GetComponent<CircleCollider2D>();

        myAnimator = GetComponent<Animator>();

        obstacleCtrl = GameObject.FindObjectOfType<obstacleController>();

        theScoreController = FindObjectOfType<scoreController>();

    }

    void FixedUpdate()
    {

        grounded = Physics2D.IsTouchingLayers(myCollider, isGround);

        //make the player able to jump
        if (Input.GetKey(KeyCode.Space) && grounded)
        {
            myRigidbody.AddForce(Vector3.up * (jumpPower * myRigidbody.mass * myRigidbody.gravityScale * 15.0f));
        }

        myAnimator.SetFloat("Speed", myRigidbody.velocity.x);
        myAnimator.SetBool("Grounded", grounded);

            //start of crouch function
            if (Input.GetKey(KeyCode.G) && grounded)
            {
                playerObject.GetComponent<BoxCollider2D>().enabled = false;
                playerObject.GetComponent<CircleCollider2D>().enabled = true;
                myAnimator.SetBool("Crouch", true);
            Debug.Log("works");
            }
            if (Input.GetKey(KeyCode.F))
            {
            playerObject.GetComponent<CircleCollider2D>().enabled = false;
            playerObject.GetComponent<BoxCollider2D>().enabled = true;
                myAnimator.SetBool("Crouch", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "killbox")
        {
            Destroy(gameObject);
            Debug.Log("triggerd");
            theScoreController.scoreInc = false;
            FindObjectOfType<gameController>().gameOver();
            //FindObjectOfType<sendScore>().sendHighScore();
        }
    }

}