using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DaveWarning : MonoBehaviour {

    public PlayerControl player;
    public Text powerupText;
    public bool test;
    // Use this for initialization
    void Start()
    {
        player = FindObjectOfType<PlayerControl>();
    }

    // Update is called once per frame

    private void Update()
    {


    }


    void OnTriggerEnter2D(Collider2D other)
    {


        powerupText.text = "Dave Has Been Found! Destroy his 4 ingredients to stop him from making his ultimate doink!!";
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        powerupText.text = "";
    }
}
