using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {
    private bool ispainted = false;
    public GameObject ball;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (GameObject.FindWithTag("Player") != null)
        {
            ball = GameObject.FindWithTag("Player");
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (ispainted == false)
            GetComponent<Renderer>().material.color = ball.GetComponent<Renderer>().material.GetColor("_Color");
        ispainted = true;
    }
}