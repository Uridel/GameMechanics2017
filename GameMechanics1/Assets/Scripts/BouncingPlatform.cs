using UnityEngine;
using System.Collections;

public class BouncingPlatform : MonoBehaviour {

	public float bounciness;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	
	
	
	void OnCollisionEnter2D(Collision2D other)
	{
		other.rigidbody.AddForce(new Vector2(-other.relativeVelocity.x, other.relativeVelocity.y) * bounciness, ForceMode2D.Impulse);

	}

}
