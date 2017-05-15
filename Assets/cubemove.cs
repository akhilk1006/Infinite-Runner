using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemove : MonoBehaviour {
    private Rigidbody2D cube;
	// Use this for initialization
	void Awake () {
        cube = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        cube.velocity = new Vector2(-3f, 0f);
	}
}
