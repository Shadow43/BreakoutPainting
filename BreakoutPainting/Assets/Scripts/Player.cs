using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public Rigidbody2D rb;
    public float speed;
    private float x;
    private float y;
    // clamping code
    private float XMaxMin = -2.71f;
    private float XMaxMax = 2.71f;
    private float YMaxMin = -6.76f;
    private float YMaxMax = -5.76f;
    public GameObject prefab;
    public Transform spawnAt;
    public int currentpaintedobjects;
    public int maxpaintedobjects;

    // Use this for initialization
    void Start ()
    {
        currentpaintedobjects = 0;
        OnPlayerDied();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    x = Input.GetAxis("Mouse X");
        y = Input.GetAxis("Mouse Y");
        Vector3 pos = (transform.position);
        pos.x = Mathf.Clamp(pos.x, XMaxMin, XMaxMax);
        pos.y = Mathf.Clamp(pos.y, YMaxMin, YMaxMax);
        transform.position = pos;
        rb.velocity = new Vector2(x, y) * speed;
    }


    public void OnPlayerDied()
    {
        GameObject go;
        go = Instantiate(prefab, spawnAt.position, prefab.transform.rotation) as GameObject;
        go.transform.SetParent(transform,true);
    }
    public void PanitedBlocks()
    {
        if (currentpaintedobjects != maxpaintedobjects)
        {
            currentpaintedobjects += 1;
        }
        else
        {
            SceneManager.LoadScene("Win");
        }
    }
}
