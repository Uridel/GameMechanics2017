using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Lose : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			SceneManager.LoadScene("level");
		}if (Input.GetKeyDown (KeyCode.Escape)) {
			SceneManager.LoadScene( "MainMenu");
		}
	}
}
