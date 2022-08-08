using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField] private Animator animator;

    public Transform attackPos;
    public LayerMask damageable;
    public float attackRange;
    public int enemyDamage;
    public int playerDamage;

    public void OnAttack(InputAction.CallbackContext context) {
        animator.SetTrigger("playerPunch");
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, damageable);
        for (int i = 0; i < enemiesToDamage.Length; i++) {
            if(enemiesToDamage[i].gameObject.tag == "enemy") {
                FindObjectOfType<AudioManager>().Play("Punch");
                enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(enemyDamage);
            } else if(enemiesToDamage[i].gameObject.tag == "Player1") {
                FindObjectOfType<AudioManager>().Play("Punch");
                enemiesToDamage[i].GetComponent<PlayerHealth>().TakeDamage(playerDamage);
            } else if(enemiesToDamage[i].gameObject.tag == "Player2") {
                FindObjectOfType<AudioManager>().Play("Punch");
                enemiesToDamage[i].GetComponent<PlayerHealth>().TakeDamage(playerDamage);
            }
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
