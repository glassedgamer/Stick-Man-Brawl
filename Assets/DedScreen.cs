using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DedScreen : MonoBehaviour {

    GameObject levelChanger;

    void Start() {
        levelChanger = GameObject.FindWithTag("LevelChanger");

        FindObjectOfType<AudioManager>().Play("Game Over");

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void MainMenu() {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Stop("Game Over");
        levelChanger.GetComponent<LevelChanger>().LoadMainMenu();
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
