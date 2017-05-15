using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour {

    Scorescript obj;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            obj = GameObject.Find("Main Camera").GetComponent<Scorescript>();
            obj.PowerUpTime += 30f;
            
            Destroy(this.gameObject);
        }
    }
}
