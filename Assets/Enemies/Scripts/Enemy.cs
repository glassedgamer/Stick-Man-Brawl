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

    void Start() {
        player1 = GameObject.FindGameObjectWithTag("Player1");
        SetEnemyValues();
    }

    void Update() {
        Swarm();
    }

    void Swarm() {
        transform.position = Vector2.MoveTowards(transform.position, player1.transform.position, speed * Time.fixedDeltaTime);
    }

    void SetEnemyValues() {
        GetComponent<EnemyHealth>().SetHealth(data.hp, data.hp);
        damage = data.damage;
        speed = data.speed;
    }

}
