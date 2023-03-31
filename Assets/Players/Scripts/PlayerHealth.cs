using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    GameObject levelChanger;

    void Start() {
        levelChanger = GameObject.FindWithTag("LevelChanger");
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        Debug.Log("Player is dying");

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0) {
            FindObjectOfType<AudioManager>().Play("Death");
            FindObjectOfType<AudioManager>().Stop("Fight Music");
            levelChanger.GetComponent<LevelChanger>().LoadDedScreen();
            
            // Destroy(this.gameObject);
        }
    }

}
