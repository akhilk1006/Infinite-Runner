using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjInvoke : MonoBehaviour {
    private float q;
    Vector3 Position;
    private float Min = 3f;
    private float Max = 20f;
    void Start()
    {
        spawn();
        
   }

    void spawn()
    {
        float g = Random.Range(Min, Max);
        q = Random.Range(-4.6f, 12.17f);
        Instantiate(Resources.Load("Bomb"), new Vector3(q, 4.5f, 0), Quaternion.identity);
        Invoke("spawn", g);
    }
    } 

