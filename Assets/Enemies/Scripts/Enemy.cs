using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private int damage = 5;
    [SerializeField]
    private float speed = 1.5f;

    [SerializeField]
    private EnemyData data;

    private GameObject player1;
    private GameObject player2;

    void Start() {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        player2 = GameObject.FindGameObjectWithTag("Player2");
        SetEnemyValues();
    }

    void Update() {
        Swarm();
    }

    void Swarm() {
        if(Vector2.Distance(transform.position, player1.transform.position) < Vector2.Distance(transform.position, player2.transform.position)) {
            transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, speed * Time.fixedDeltaTime);
        } else {
            transform.position = Vector2.MoveTowards(transform.position, player2.transform.position, speed * Time.fixedDeltaTime);
        }
    }

    void SetEnemyValues() {
        GetComponent<EnemyHealth>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

}
