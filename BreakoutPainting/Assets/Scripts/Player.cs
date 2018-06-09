using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    // Change this to mouse movements
    private float x;
    private float y;
    // clamping code
    private float XMaxMin = -2.71f;
    private float XMaxMax = 2.71f;
    private float YMaxMin = -6.76f;
    private float YMaxMax = -5.76f;
    public GameObject prefab;
    public Transform spawnAt;
    public int paintedblocks;

    // Use this for initialization
    void Start ()
    {
        paintedblocks = 0;
        OnPlayerDied();
    }

    // Change ALL keyboard movement code to mouse movement code -- need help!
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        if (x < 0)
        {
            MoveLeft();
        }
        if (x > 0)
        {
            MoveRight();
        }
        if (x == 0)
        {
            Stop();
        }
        if (y > 0)
        {
            MoveUp();
        }
        if (y < 0)
        {
            MoveDown();
        }
        Vector3 pos = (transform.position);
        pos.x = Mathf.Clamp(pos.x, XMaxMin, XMaxMax);
        pos.y = Mathf.Clamp(pos.y, YMaxMin, YMaxMax);
        transform.position = pos;
    }
    void MoveLeft()
    {
        rb.velocity = new Vector2 (-speed,0);
    }
    void MoveRight()
    {
        rb.velocity = new Vector2(speed, 0);
    }
    void Stop()
    {
        rb.velocity = Vector2.zero;
    }
    void MoveUp()
    {
        rb.velocity = new Vector2(0, speed);
    }
    void MoveDown()
    {
        rb.velocity = new Vector2(0, -speed);
    }

    public void OnPlayerDied()
    {
        GameObject go;
        go = Instantiate(prefab, spawnAt.position, prefab.transform.rotation) as GameObject;
        go.transform.SetParent(transform,true);
    }
    public void PanitedBlocks()
    {
        paintedblocks += 1;
    }
}
