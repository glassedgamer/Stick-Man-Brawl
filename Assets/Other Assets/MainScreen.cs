using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainScreen : MonoBehaviour {

    public void StartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        FindObjectOfType<AudioManager>().Stop("Lobby Music");
        FindObjectOfType<AudioManager>().Play("Fighting Theme");
    }

    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }

}
