using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blast : MonoBehaviour {
    Rigidbody2D bombInstance;
    public float movementSpeed = 5f;
    private void Start()
    {
        bombInstance = GetComponent<Rigidbody2D>();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(1);
        }
        else
        {
            if(collision.gameObject.tag != "Destroyer")
                Destroy(collision.gameObject);
        }
    }

}
