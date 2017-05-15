using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour {
    private Rigidbody2D cowboy;

	// Use this for initialization
	void  Awake() {
        cowboy = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        cowboy.velocity = new Vector2(2, cowboy.velocity.y);
	}
}
