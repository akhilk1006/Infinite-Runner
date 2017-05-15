using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpMovement : MonoBehaviour {

    public static float speed = -7f;
    private Rigidbody2D myBody;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void Update () {
        myBody.velocity = new Vector2(speed, 0f);
    }
}
