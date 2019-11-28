using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AITurnTrigger : MonoBehaviour {
    //TODO Separated and organized public/ private variables in 
    //the variable field for a better view of all variables
    Enemy myEnemy;
    Enemy[] myEnemyArray;

    public bool bIsLeft = true;


    private void Start() {
        myEnemyArray = GameObject.FindObjectsOfType<Enemy>();
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        AITurn();
    }

    //TODO Added bIsLeft to fix the previously unfunctioning if statement to get it to work
    //TODO Removed unnessesary variable in Enemy script to decreas amount of variables
    // for decreased memory usage 
    public void AITurn() {
        for (int i = myEnemyArray.Length - 1; i >= 0; i--) {
            if (bIsLeft && myEnemyArray[i] != null) {
                myEnemyArray[i].bIsMovingLeft = false;
                //myEnemyArray[i].bIsMovingRight = true;
                bIsLeft = false;
                myEnemyArray[i].DownwardsStep();
            }

            else if (!bIsLeft && myEnemyArray[i] != null) {
                //myEnemyArray[i].bIsMovingRight = false;
                myEnemyArray[i].bIsMovingLeft = true;
                bIsLeft = true;
                myEnemyArray[i].DownwardsStep();
            }
        }
    }
}
