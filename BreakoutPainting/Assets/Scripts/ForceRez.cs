using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceRez : MonoBehaviour {

    public int width;
    public int hight;

	// Use this for initialization
	void Start () {
        Screen.SetResolution(width, hight, true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
