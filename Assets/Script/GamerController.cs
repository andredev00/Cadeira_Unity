using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GamerController : MonoBehaviour {
    
    public static float timeLeft;
    public GameObject GameOverText;
    public GameObject restartButton;
    public Text timerText;



    // Use this for initialization
    void Start () {
        if (timeLeft == 0)
        {
            timeLeft = 40.0f;
        }
       
        /*
        GameOverText.SetActive(false); 
        restartButton.SetActive(false);
        */
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
            
        
        timerText.text = "Time Left:" + Mathf.RoundToInt (timeLeft);

		
	}

    public void addpoint (float tempo)
    {
        timeLeft += tempo;
    }

}

