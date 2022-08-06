using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    [SerializeField] private Animator animator;

    public Transform attackPos;
    public LayerMask damageable;
    public float attackRange;
    public int damage;

    public void OnAttack(InputAction.CallbackContext context) {
        animator.SetTrigger("playerPunch");
        Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, damageable);
        for (int i = 0; i < enemiesToDamage.Length; i++) {
            enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
        }
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}
