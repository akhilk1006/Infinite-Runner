using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleJump : MonoBehaviour {
    int i = 0;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            i++;
            Destroy(this.gameObject);
            if (i < 2)
            {
                Scorescript.NoOfJumps++;
            }
        }
    }
}
