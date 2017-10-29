using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	 
	public static int score;
    public Text scoreText;
	public static PlayerControl playerControl;

	void Start(){
		playerControl = FindObjectOfType<PlayerControl> ();
   
		score = 0;
	}

	void Update(){
        scoreText.text =  score + " out of 5";
    }
	public static void AddPoints (int pointsToAdd){

		score += pointsToAdd;

		if (score == 5) {
			playerControl.playerLives ++;
			Reset();
			


		}	
	}
	public static void Reset(){
		score = 0;
	}
}
