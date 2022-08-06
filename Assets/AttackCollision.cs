using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour {

    public int damage = 20;
    
    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "enemy") {
            col.GetComponent<EnemyHealth>().TakeDamage(damage);
        } else if(col.gameObject.tag == "Player2") {
            col.GetComponent<PlayerHealth>().TakeDamage(damage);
        }
    }
}
