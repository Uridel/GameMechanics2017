using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	 
	public static int score;
	public static PlayerControl playerControl;






	void Start(){
		playerControl = FindObjectOfType<PlayerControl> ();
	    


		score = 0;
	}

	void Update(){

	}
	public static void AddPoints (int pointsToAdd){

		score += pointsToAdd;
		Debug.Log (score);
		if (score == 5) {
			playerControl.playerLives = 2;
			Reset();
			Debug.Log (playerControl.playerLives);


		}	
	}
	public static void Reset(){
		score = 0;
	}
}
