using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public GameObject blood;

    [SerializeField]
    private int health = 100;

    private int maxHealth = 100;

    public void SetHealth(int max_health, int health) {
        this.maxHealth = max_health;
        this.health = health;
    }

    public void TakeDamage(int damage) {
        GetComponent<Enemy>().Dazed();
        Instantiate(blood, transform.position, Quaternion.identity);

        health -= damage;
        Debug.Log("Damage dealt!");

        if(health <= 0) {
            FindObjectOfType<AudioManager>().Play("Death");
            Destroy(this.gameObject);
        }
    }

}
