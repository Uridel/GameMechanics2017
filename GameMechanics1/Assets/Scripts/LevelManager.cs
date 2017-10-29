using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;
    private Scene scene;

    private PlayerControl player;


	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> ();
         scene = SceneManager.GetActiveScene();
      
        if(scene.name == "Level2")
        {
            player.unlockDoubleJump = true;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (scene.name == "Level2")
        {
            player.unlockDoubleJump = true;
        }

    }

	public void RespawnPlayer(){
		
        player.transform.position = player.currentCheckpoint;
        
		
       
	}
}
