using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    [SerializeField]
    private int health = 100;

    private int maxHealth = 100;

    public void SetHealth(int max_health, int health) {
        this.maxHealth = max_health;
        this.health = health;
    }

    public void TakeDamage(int damage) {
        health -= damage;
        Debug.Log("Damage dealt!");

        if(health <= 0)
            Destroy(this.gameObject);
    }

}
