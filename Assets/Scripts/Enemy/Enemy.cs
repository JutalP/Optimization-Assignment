using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    //TODO Separated and organized public/ private variables in 
    //the variable field for a better view of all variables
    public float movementSpeed = 2f;
    public bool bIsMovingLeft = false;

    //TODO Removed bIsMovingRight in Enemy script and AItrigger script because it was 
    //an unnessesary variable, inteaed of bIsMovingRight in if statement i replaced it with 
    //"!bIsmovingLeft"
    //public bool bIsMovingRight = false;

    AITurnTrigger myTurnTrigger;
    Rigidbody2D myRigidbody;
    float minXPos = -8.25f;
    float maxXPos = 8.25f;

    private void Start() {
        myRigidbody = GetComponent<Rigidbody2D>();
        bIsMovingLeft = true;
        //bIsMovingRight = false;
    }

    private void Update() {
        //Old code

        //if (bIsMovingLeft)
        //    myRigidbody.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, 0);

        //else if (bIsMovingRight)
        //    myRigidbody.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, 0);

        //TODO Moved if statement to a function for better readability, deviding code snipets into functions can help improving the ease to read couse of the function name(header).
        Movement();
    }

    //TODO Renamed function from FolkesFunktion to DownwardsStep for clear explenation of what the code does
    public void DownwardsStep() {
        transform.position += new Vector3(0, -0.2f, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        myTurnTrigger = collision.gameObject.GetComponent<AITurnTrigger>();

        if (collision.gameObject == myTurnTrigger || collision.gameObject.GetComponent<Enemy>()) {
            return;
        }
        else
            Destroy(gameObject);
    }

    //TODO The function with the enemy AI movement
    private void Movement() {
        if (bIsMovingLeft)
            myRigidbody.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, 0);

        else if (!bIsMovingLeft)
            myRigidbody.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, 0);
    }
}
