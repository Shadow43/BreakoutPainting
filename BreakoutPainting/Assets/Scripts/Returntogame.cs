using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Returntogame : MonoBehaviour {
    public GameObject ReturntoGame;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void GameMenu()
    {
        SceneManager.LoadScene("Game");
    }

}
