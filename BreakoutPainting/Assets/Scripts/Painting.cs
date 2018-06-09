using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour {
    private bool ispainted = false;
    public GameObject ball;
    Collider2D m_ObjectCollider;

    // Use this for initialization
    void Start() {
        m_ObjectCollider = GetComponent<Collider2D>();
        m_ObjectCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update() {
        if (GameObject.FindWithTag("Player") != null)
        {
            ball = GameObject.FindWithTag("Player");
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<Renderer>().material.color = ball.GetComponent<Renderer>().material.GetColor("_Color");
        var p = FindObjectOfType<Player>();
        p.PanitedBlocks();
        ispainted = true;
        m_ObjectCollider.isTrigger = true;
    }
}