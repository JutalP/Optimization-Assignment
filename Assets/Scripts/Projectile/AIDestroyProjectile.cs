using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIDestroyProjectile : MonoBehaviour {

    AISpawnProjectile myAIProjectileSpawner;

    private void Start() {
        myAIProjectileSpawner = GameObject.FindObjectOfType<AISpawnProjectile>();
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<Enemy>())
            return;
        else {
            Destroy(collision.gameObject);
        }
    }
}
