using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject[] enemies;

    public float waveBreak = 5f;
    int enemyAmount = 0;

    void Start() {
        StartCoroutine(EnemyWave());
    }

    void SpawnEnemies() {
        float randomLocationX = Random.Range(2f, 8f);
        float randomLocationY = Random.Range(-1.92f, -4f);
        GameObject clone = Instantiate(enemies[0], new Vector2(randomLocationX, randomLocationY), Quaternion.identity);
    }

    IEnumerator EnemyWave() {
        while (true) {
            yield return new WaitForSeconds(waveBreak);
            enemyAmount++;
            for(int i = 0; i < enemyAmount; i++) {
                SpawnEnemies();
            }
        }
        
    }

}
