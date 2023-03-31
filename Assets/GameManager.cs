using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject[] enemies;

    public float waveBreak = 5f;
    int enemyAmount = 3;

    [Header("Points")]
    public int points = 0;
    public int highscore = 0;

    [Header("Score Text")]
    public Text scoreText;
    public Text highscoreText;

    void Start() {
        FindObjectOfType<AudioManager>().Play("Fight Music");
        highscore = PlayerPrefs.GetInt("highscore", 0);
        scoreText.text = points.ToString() + " Points";
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();

        StartCoroutine(EnemyWave());
    }

    public void AddPoint(int value) {
        points += value;
        scoreText.text = points.ToString() + " Points";
        if(highscore < points) {
            PlayerPrefs.SetInt("highscore", points);
        }
    }

    void SpawnEnemies() {
        float randomLocationX = Random.Range(2f, 8f);
        float randomLocationY = Random.Range(-1.92f, -4f);
        GameObject clone = Instantiate(enemies[0], new Vector2(randomLocationX, randomLocationY), Quaternion.identity);
    }

    IEnumerator EnemyWave() {
        while (true) {
            yield return new WaitForSeconds(waveBreak);
            // enemyAmount++;
            for(int i = 0; i < enemyAmount; i++) {
                SpawnEnemies();
            }
        }
    }


}
