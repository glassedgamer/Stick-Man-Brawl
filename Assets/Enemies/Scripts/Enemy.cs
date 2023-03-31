using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 1.5f;

    private bool facingRight = true;

    private float dazedTime;
    public float startDazedTime;

    float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask damageable;
    public float attackRange;

    [SerializeField]
    private EnemyData data;

    public Animator animator;

    private GameObject player1;
    private GameObject player2;

    float player1Dist;
    float player2Dist;

    GameObject gameManager;

    void Start() {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");

        gameManager = GameObject.FindWithTag("GameManager");

        SetEnemyValues();
    }

    void Update() {
        player1Dist = Vector2.Distance(transform.position, player1.transform.position);
        player2Dist = Vector2.Distance(transform.position, player2.transform.position);

        if(dazedTime <= 0) {
            animator.SetBool("isWalking", true);
            speed = data.speed;
        } else {
            animator.SetBool("isWalking", false);
            speed = 0;
            dazedTime -= Time.deltaTime;
        }

        if(player1.GetComponent<PlayerHealth>().currentHealth <= 0 || player2.GetComponent<PlayerHealth>().currentHealth <= 0) {
            Destroy(this.gameObject);
        }

        Swarm();

    }

    public void Dazed() {
        dazedTime = startDazedTime;
    }

    void Swarm() {
        if(player1Dist < player2Dist) {

            if(gameManager.GetComponent<PauseMenu>().isPaused == false) {
                //moves player and plays walk animation
                transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, speed * Time.deltaTime);

                //flips the enemy
                if(player1.transform.position.x < transform.position.x && facingRight == true) {
                    Flip();
                } else if(player1.transform.position.x > transform.position.x && facingRight == false) {
                    Flip();
                }
            }

            //attacks player
            if(timeBtwAttack <= 0) {
                if(player1Dist <= 6){
                    speed = 0f;
                    FindObjectOfType<AudioManager>().Play("Swipe");
                    animator.SetTrigger("Punch");
                    Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, damageable);
                    for (int i = 0; i < enemiesToDamage.Length; i++) {
                        FindObjectOfType<AudioManager>().Play("Punch");
                        enemiesToDamage[i].GetComponent<PlayerHealth>().TakeDamage(damage);
                    }
                }
                timeBtwAttack = startTimeBtwAttack;
            } else {
                speed = data.speed;
                timeBtwAttack -= Time.deltaTime;
            }
        } else if(player1Dist > player2Dist) {
            //moves player and plays walk animation
            animator.SetBool("isWalking", true);
            transform.position = Vector2.MoveTowards(transform.position, player2.transform.position, speed * Time.deltaTime);

            //flips the enemy
            if(player2.transform.position.x < transform.position.x && facingRight == true) {
                Flip();
            } else if(player2.transform.position.x > transform.position.x && facingRight == false) {
                Flip();
            }

            //attacks player
            if(timeBtwAttack <= 0) {
                if(player2Dist <= 6){
                    speed = 0f;
                    FindObjectOfType<AudioManager>().Play("Swipe");
                    animator.SetTrigger("Punch");
                    Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, damageable);
                    for (int i = 0; i < enemiesToDamage.Length; i++) {
                        FindObjectOfType<AudioManager>().Play("Punch");
                        enemiesToDamage[i].GetComponent<PlayerHealth>().TakeDamage(damage);
                    }
                }
                timeBtwAttack = startTimeBtwAttack;
            } else {
                timeBtwAttack -= Time.deltaTime;
                speed = data.speed;
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
        
    }

    void OnDrawGizmosSelected() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.tag == "Player1" || col.tag == "Player2") {
            FindObjectOfType<AudioManager>().Play("Punch");
            col.GetComponent<PlayerHealth>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }

}
