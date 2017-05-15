using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Destroyer1script : MonoBehaviour {
    Scorescript powerup;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Player")
        {
            powerup = GameObject.Find("Main Camera").GetComponent<Scorescript>();
            if (powerup.PowerUpTime > 50)
            {
                Destroy(collision.gameObject);
                Instantiate(Resources.Load("Player"), new Vector3(-3.17f, 2.03f, 0f), Quaternion.identity);
                powerup.PowerUpTime -= 50;
                if (powerup.PowerUpTime < 30)
                    powerup.PowerUpTime = 30;
            }
            else
            {
                Obstacle.speed = -10f;
                PowerUpMovement.speed = -7f;
                Scorescript.NoOfJumps = 0;
                SceneManager.LoadScene(1);
                return;
            }
        }
        else if (collision.gameObject.transform.parent)
        {
            Destroy(collision.gameObject.transform.parent.gameObject);

        }
        else
        {
            Destroy(collision.gameObject);
        }
    }
}
