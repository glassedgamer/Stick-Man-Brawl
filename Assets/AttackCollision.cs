using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollision : MonoBehaviour {

    public int damage = 40;
    
    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "enemy") {
            Debug.Log("Your mom");
            col.GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }
}
