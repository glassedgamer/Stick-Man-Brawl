using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 1.5f;

    private bool facingRight = true;

    float player1Dist;
    float player2Dist;
    float timeBtwAttack;
    public float startTimeBtwAttack;

    [SerializeField]
    private EnemyData data;

    public Animator animator;

    private GameObject player1;
    private GameObject player2;

    void Start() {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");

        SetEnemyValues();
    }

    void Update() {
        player1Dist = Vector2.Distance(transform.position, player1.transform.position);
        player2Dist = Vector2.Distance(transform.position, player2.transform.position);

        Swarm();
    }

    void Swarm() {
        if(player1Dist < player2Dist) {
            //moves player and plays walk animation
            animator.SetBool("isWalking", true);
            transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, speed * Time.fixedDeltaTime);

            //flips the enemy
            if(player1.transform.position.x < transform.position.x && facingRight == true) {
                Flip();
            } else if(player1.transform.position.x > transform.position.x && facingRight == false) {
                Flip();
            }

            //attacks player
            if(timeBtwAttack <= 0) {
                if(player1Dist <= 3){
                    animator.SetTrigger("Punch");
                }
                timeBtwAttack = startTimeBtwAttack;
            } else {
                timeBtwAttack -= Time.deltaTime;
            }
        } else if(player1Dist > player2Dist) {
            //moves player and plays walk animation
            animator.SetBool("isWalking", true);
            transform.position = Vector2.MoveTowards(transform.position, player2.transform.position, speed * Time.fixedDeltaTime);

            //flips the enemy
            if(player2.transform.position.x < transform.position.x && facingRight == true) {
                Flip();
            } else if(player2.transform.position.x > transform.position.x && facingRight == false) {
                Flip();
            }

            //attacks player
            if(timeBtwAttack <= 0) {
                if(player2Dist <= 3){
                    animator.SetTrigger("Punch");
                }
                timeBtwAttack = startTimeBtwAttack;
            } else {
                timeBtwAttack -= Time.deltaTime;
            }
        }
    }

    void Flip() {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }

    void SetEnemyValues() {
        GetComponent<EnemyHealth>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

}
