using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

    private static int score;
    static Text gameScore;
	// Use this for initialization
	void Start () {
        score = 0;
        gameScore = GetComponent<Text>();
	}
	
	// Update is called once per frame

    public static void Incrementscore()
    {
        score++;
        gameScore.text = score.ToString();
    }
}
