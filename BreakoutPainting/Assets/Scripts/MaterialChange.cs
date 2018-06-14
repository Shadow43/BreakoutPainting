using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour {

    public Material[] material;
    private Renderer rend;
    public AudioClip colourchange;
    AudioSource audioSource;


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            rend.sharedMaterial = material[1];
            audioSource.PlayOneShot(colourchange);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            rend.sharedMaterial = material[2];
            audioSource.PlayOneShot(colourchange);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            rend.sharedMaterial = material[3];
            audioSource.PlayOneShot(colourchange);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            rend.sharedMaterial = material[4];
            audioSource.PlayOneShot(colourchange);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            rend.sharedMaterial = material[5];
            audioSource.PlayOneShot(colourchange);
        }
    }

    public bool IsMatZero()
    {
        return rend.sharedMaterial == material[0];
    }
}
