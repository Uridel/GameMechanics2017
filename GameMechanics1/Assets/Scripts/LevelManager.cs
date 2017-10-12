using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

	private PlayerControl player;
//	private Pickup pickup;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> ();
		//pickup = FindObjectOfType<Pickup> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer(){
		Debug.Log ("Player Respawn");
		player.transform.position = currentCheckpoint.transform.position;
		player.unlockDoubleJump = false;
		//pickup.transform.position = 
	}
}
