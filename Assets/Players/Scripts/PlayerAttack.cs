using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField] private Animator animator;

    private float timeBtwAttack;
    public float startDazedTime;

    public Transform attackPos;
    public LayerMask damageable;
    public float attackRange;
    public int enemyDamage;
    public int playerDamage;

    void Update() {
        if(timeBtwAttack > 0) {
            timeBtwAttack -= Time.deltaTime;
        }
    }

    public void OnAttack(InputAction.CallbackContext context) {
        if(timeBtwAttack <= 0) {
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

            timeBtwAttack = startDazedTime;
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
