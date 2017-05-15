﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    public static float speed = -10f;
    private Rigidbody2D myBody;

    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        myBody.velocity = new Vector2(speed, 0f);
	}
}
