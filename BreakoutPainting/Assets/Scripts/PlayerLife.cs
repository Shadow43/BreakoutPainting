using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLife : MonoBehaviour {
    public float time;
    public float deathupdate = 3.1f;
    public Image image;
    public float AlphaTransparancy;
    public bool playerdead;

    // Use this for initialization
    void Start () {
        image = GetComponent<Image>();
        image.color = new Color(0, 0, 0, AlphaTransparancy);
    }

    // Update is called once per frame
    void Update () {
        if (playerdead == false)
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
        }
    }
