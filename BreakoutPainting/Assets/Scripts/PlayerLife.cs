using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour
{
    public float time;
    public float deathupdate = 3.1f;
    public Image image;
    public float AlphaTransparancy;
    public bool playerdead;
    public GameObject hallucinations;
    public GameObject painting;
    public Text introtext;
    public bool gamestarted;
    public float hallucinationtimer;
    public float hallucinationlength = 5f;

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
}
