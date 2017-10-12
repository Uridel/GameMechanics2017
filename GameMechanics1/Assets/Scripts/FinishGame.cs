using UnityEngine;
using System.Collections;


public class FinishGame : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {
			//for(int i =0; i<10 ;i++ ){GUI.Label(new Rect(Screen.width/2, Screen.height/2, 100, 20), "Level Complete");}
			Debug.Log ("Player Won");
			Application.LoadLevel("Win");

		
		}
		
	}
}
