using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject[] enemies;

    public float waveBreak = 1f;

    void Start() {
        StartCoroutine(EnemyWave());
    }

    void RandomizeEnemies() {
        int randomIndex = Random.Range(0, enemies.Length);

        float randomLocationX = Random.Range(0f, 8f);
        float randomLocationY = Random.Range(-1.92f, -4f);
        GameObject clone = Instantiate(enemies[randomIndex], new Vector2(randomLocationX, randomLocationY), Quaternion.identity);
    }

    IEnumerator EnemyWave() {
        yield return new WaitForSeconds(waveBreak);

        for(int i = 0; i < 5; i++) {
            RandomizeEnemies();
        }
    }

}
