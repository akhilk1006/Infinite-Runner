using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorescript : MonoBehaviour {
    public static int NoOfJumps;
    public float Score = 0;
    public float PowerUpTime = 30f;
    private void Start()
    {
        NoOfJumps = 0;
    }
    void Update()
    {
        Score += Time.deltaTime;
        PowerUpTime -= Time.deltaTime; 
        if (PowerUpTime <= 0)
        {
            SceneManager.LoadScene(1);
        } 
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 100, 30), "Score: " + (int)(Score*10));
        GUI.Label(new Rect(10, 50, 100, 30), "Power: "+ (int)PowerUpTime);

    }
     void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)(Score * 10));   
    }

}
