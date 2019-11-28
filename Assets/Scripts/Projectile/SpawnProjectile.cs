using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnProjectile : MonoBehaviour {
    public float movementSpeed;
    [SerializeField] GameObject projectilePrefab;

    public void Move() {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity) as GameObject;
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, movementSpeed);
    }
}
