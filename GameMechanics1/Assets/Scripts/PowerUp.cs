using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {
	public PlayerControl player;
    public Text powerupText;
    public int delay;
    public float time;
    public bool test;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerControl> ();
        delay = 2;
        test = false;
   
	}
	
	// Update is called once per frame
	void Update () {
        
	    if(test)
        {
          
            powerupText.text = "Double Jump unlocked";
            time += Time.deltaTime;
            if (time > delay)
            {
            
                powerupText.text = " ";
                Destroy(gameObject);
            }
        }
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Player") {
			player.unlockDoubleJump = true;
            test = true;
           
          
		}
	}

   
}
