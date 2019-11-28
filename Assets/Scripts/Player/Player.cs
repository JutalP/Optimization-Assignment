using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    //TODO Separated and organized public/ private variables in 
    //the variable field for a better view of all variables
    public float movementSpeed;

    SpawnProjectile myProjectile;
    float minXPos = -8.25f;
    float maxXPos = 8.25f;

    private void Awake() {
        myProjectile = GetComponent<SpawnProjectile>();
    }

    //TODO Removed Start function with nothing in it for less lines of code which helps 
    //with the readability
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        //Old Code
        //var deltaX = Input.GetAxis("Horizontal");
        //var xPos = transform.position.x + deltaX * movementSpeed * Time.fixedDeltaTime;
        //var absxPos = Mathf.Clamp(xPos, minXPos, maxXPos);
        //transform.position = new Vector2(absxPos, transform.position.y);

        //if (Input.GetButtonDown("Fire1")) {
        //    myProjectile.Move();
        //}

        //TODO Moved code in update to functions for better readability
        Move();
        Fire();
    }

    private void Move() {
        var deltaX = Input.GetAxis("Horizontal");
        var xPos = transform.position.x + deltaX * movementSpeed * Time.fixedDeltaTime;
        var absxPos = Mathf.Clamp(xPos, minXPos, maxXPos);
        transform.position = new Vector2(absxPos, transform.position.y);
    }

    private void Fire() {
        if (Input.GetButtonDown("Fire1")) {
            myProjectile.Move();
        }
    }
}
