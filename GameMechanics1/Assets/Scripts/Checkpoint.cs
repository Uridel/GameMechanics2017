using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
       
        if (other.name == "Player")
        {
            PlayerControl myPlayer = (PlayerControl)GameObject.Find("Player").GetComponent("PlayerControl");

            myPlayer.currentCheckpoint = transform.position;


        }
    }
}