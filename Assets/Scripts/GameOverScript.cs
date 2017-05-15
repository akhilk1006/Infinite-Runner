using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour {
    int Score = 0;
	// Use this for initialization
	void Start () {
        Score = PlayerPrefs.GetInt("Score");
	}
     void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40, 50, 80, 30), "GAME OVER");
        GUI.Label(new Rect(Screen.width / 2 - 40, 100, 80, 30), "Score :" + Score);
        if (GUI.Button(new Rect(Screen.width / 2 - 30, 125, 60, 30), "Retry"))
        {
            SceneManager.LoadScene(0);
        } 
    }


}
