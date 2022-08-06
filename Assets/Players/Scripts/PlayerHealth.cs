using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "damage")
            TakeDamage(20);
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

}
