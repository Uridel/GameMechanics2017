using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

	private LevelManager levelManager;
	private PlayerControl playerControl;

	// Use this for initialization
	void Start () {
		levelManager = FindObjectOfType<LevelManager>();
		playerControl = FindObjectOfType<PlayerControl> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {
			playerControl.playerLives = playerControl.playerLives -1;
			Debug.Log(playerControl.playerLives);
			if(playerControl.playerLives <= 0){
				levelManager.RespawnPlayer();
				Application.LoadLevel("Loss");
			}
		}
	
	}
}
