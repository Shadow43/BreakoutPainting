using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour {

    public Material[] material;
    private Renderer rend;


    // Use this for initialization
    void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];

    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            rend.sharedMaterial = material[1];
        if (Input.GetKeyDown(KeyCode.Alpha2))
            rend.sharedMaterial = material[2];
        if (Input.GetKeyDown(KeyCode.Alpha3))
            rend.sharedMaterial = material[3];
        if (Input.GetKeyDown(KeyCode.Alpha4))
            rend.sharedMaterial = material[4];
        if (Input.GetKeyDown(KeyCode.Alpha5))
            rend.sharedMaterial = material[5];
    }

    public bool IsMatZero()
    {
        return rend.sharedMaterial == material[0];
    }
}
