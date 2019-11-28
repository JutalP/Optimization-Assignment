using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawnProjectile : MonoBehaviour {
    public float movementSpeed;
    [SerializeField] GameObject projectilePrefab;

    private void Update() {
        AIShoot();
    }

    private void AIShoot() {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity) as GameObject;
        projectile.GetComponent<Rigidbody2D>().velocity = new Vector2(0, movementSpeed);
    }
}
