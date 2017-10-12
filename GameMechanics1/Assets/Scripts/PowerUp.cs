using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	public PlayerControl player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {
			player.unlockDoubleJump = true;

			Destroy (gameObject);
		}
	}
}
