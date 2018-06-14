using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour {
    public float timer;
    public float timerend;
    public bool startinggame;
    public bool pictureshown;
    public GameObject startgame;
    public GameObject dacredits;
    public GameObject[] paintingblocks;
    public GameObject painting;
    public Text introtext;
    public GameObject paddleplayer;
    AudioSource music;

    // Use this for initialization
    void Start() {
        startinggame = false;
        music = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() {
        if (startinggame == true && pictureshown == false)
        {
            timer += Time.deltaTime;
            if (timer >= timerend)
            {
                painting.SetActive(false);
                pictureshown = true;
                foreach (GameObject pb in paintingblocks)
                {
                    pb.SetActive(true);
                }
                var d = FindObjectOfType<PlayerLife>();
                paddleplayer.SetActive(true);
                d.StarttheGame();
            }
        }
    }

    public void Startgame()
    {
        music.Play();
        introtext.GetComponent<Text>().enabled = false;
        painting.SetActive(true);
        startinggame = true;
        dacredits.SetActive(false);
        startgame.SetActive(false);
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
