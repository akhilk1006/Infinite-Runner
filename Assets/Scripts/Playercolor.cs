using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercolor : MonoBehaviour {
     SpriteRenderer obj;
    Scorescript poweruptime;
    void Start() {
        
        obj = GetComponent<SpriteRenderer>();
        poweruptime = GameObject.Find("Main Camera").GetComponent<Scorescript>();


    }

    // Update is called once per frame
    void Update() {
        if( poweruptime.PowerUpTime< 25)
        {
            obj.color = Color.red;
        }
        else
        {
            obj.color = Color.white;
        }
    }
}




    

   