using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	public int pointsToAdd;
	public int curPoints;

	// Use this for initialization

	
	

	void OnTriggerEnter2D( Collider2D other){
		if (other.GetComponent<PlayerControl> () == null) {
			return;
		}

		ScoreManager.AddPoints (pointsToAdd);
	    
		Destroy (gameObject);
	}
}
