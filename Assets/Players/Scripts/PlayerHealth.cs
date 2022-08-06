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

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        Debug.Log("Player is dying");

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0)
            Destroy(this.gameObject);
    }

}
