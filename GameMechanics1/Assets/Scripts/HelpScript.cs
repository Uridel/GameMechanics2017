using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class HelpScript : MonoBehaviour {
    public PlayerControl player;
    public Text powerupText;
    public bool test;
    // Use this for initialization
    void Start () {
        player = FindObjectOfType<PlayerControl>();
    }

    // Update is called once per frame

    private void Update()
    {
        

    }


    void OnTriggerEnter2D(Collider2D other)
    {
      
        
            powerupText.text = "Take These Coins! \n But carefull you can only get them once!";

        
        
    }
}
