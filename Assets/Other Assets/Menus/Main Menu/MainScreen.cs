using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScreen : MonoBehaviour {

    GameObject levelChanger;

    void Start() {
        levelChanger = GameObject.FindWithTag("LevelChanger");

        FindObjectOfType<AudioManager>().Play("Lobby Music");
    }

    public void StartGame() {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        levelChanger.GetComponent<LevelChanger>().LoadNextLevel();
        FindObjectOfType<AudioManager>().Stop("Lobby Music");
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
