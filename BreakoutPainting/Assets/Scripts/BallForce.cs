using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour {

    public Rigidbody2D rb;
    public float ballForce;
    private bool gameStarted = false;

    // Use this for initialization
    void Start () {
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        MaterialChange mc = GetComponent<MaterialChange>();
        if (Input.GetMouseButtonDown(0) && gameStarted == false && !mc.IsMatZero())
        {
            {
                rb.isKinematic = false;
                rb.AddForce(new Vector2(ballForce, ballForce));
                transform.SetParent(null);
                gameStarted = true;
            }
        }
    }
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Deathzone")
            {
                Destroy(this.gameObject);
                var p = FindObjectOfType<Player>();
                p.OnPlayerDied();
                var d = FindObjectOfType<PlayerLife>();
                d.OnPlayerDeath();
            }
        }

    }

