using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamespeed : MonoBehaviour {
    Scorescript object3;
    int compare;
    private void Start()
    {
        compare = 300;
        Obstacle.speed = -10f;
        PowerUpMovement.speed = -7f;
        object3 = GameObject.Find("Main Camera").GetComponent<Scorescript>();
    }

    private  void Update()
    {
        
        if(object3.Score*10 > compare)
        {
            PowerUpMovement.speed = Obstacle.speed ;
            Obstacle.speed -= 2;
            compare += 200;
            Debug.Log("powerspeed" + PowerUpMovement.speed);
            Debug.Log("ObstacleSpeed" + Obstacle.speed);
            Debug.Log("comparevalue" + compare);
        }
    }

}
