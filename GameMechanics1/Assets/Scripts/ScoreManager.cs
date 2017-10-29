using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
    public Sprite fullHealth, halfHealth, fullerHealth;
    public static int score;
    public Text scoreText;
    public Image image;
	public static PlayerControl playerControl;

	void Start(){
		playerControl = FindObjectOfType<PlayerControl> ();
   
		score = 0;
	}

	void Update(){
        scoreText.text =  score + " out of 5";
        if(playerControl.playerLives == 1)
        {
            image.GetComponent<Image>().sprite = halfHealth;
        }
        if(playerControl.playerLives == 2)
        {
            image.GetComponent<Image>().sprite = fullHealth;
        }
        if(playerControl.playerLives == 3)
        {
            image.GetComponent<Image>().sprite = fullerHealth;
        }
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
