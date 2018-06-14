using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public float time;
    public float deathupdate = 3.1f;
    public Image image;
    public float AlphaTransparancy;
    public bool playerdead;
    public GameObject hallucinations;
    public bool gamestarted;
    public float hallucinationtimer;
    public float hallucinationlength;


    // Use this for initialization
    void Start()
    {
        image = GetComponent<Image>();
        image.color = new Color(0, 0, 0, AlphaTransparancy);
        hallucinationtimer = Random.Range(5f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerdead == false && gamestarted == true)
        {
            time += Time.deltaTime;
        }
        if (time >= deathupdate)
        {
            deathupdate = deathupdate + 3f;
            AlphaTransparancy += 0.05f;
        }
        image.color = new Color(0, 0, 0, AlphaTransparancy);
        if (AlphaTransparancy >= 1f)
        {
            playerdead = true;
        }
        if (time >= hallucinationtimer)
        {
            hallucinations.SetActive(true);
            hallucinationlength = hallucinationtimer + 5f;
            hallucinationtimer = hallucinationtimer + Random.Range(5f, 15f);
        }
        if (time >= hallucinationlength)
        {
            hallucinations.SetActive(false);
        }
        if (hallucinations.active == true && playerdead == true)
        {
            hallucinations.SetActive(false);
            SceneManager.LoadScene("GameOver", LoadSceneMode.Additive);
        }

    }
    public void OnPlayerDeath()
    {
        AlphaTransparancy += 0.08f;
        image = GetComponent<Image>();
        image.color = new Color(0, 0, 0, AlphaTransparancy);
    }
    public void OnPlayerPaint()
    {
        AlphaTransparancy -= 0.05f;
    }
    public void StarttheGame()
    {
        gamestarted = true;
    }
}
