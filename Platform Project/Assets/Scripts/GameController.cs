using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour {
    private int playerScore;
    private Text text;
	// Use this for initialization
	void Start () {
        //set the score to zero
        playerScore = 0;

        //get the text componenet
        text = GetComponent<Text>();
        //set the texts text
        text.text = "Score: 0";
	}
	
	// Update is called once per frame
	void Update () {
        //set the text to the players score
        text.text = "Score: " + playerScore;
	}

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }
}
