using UnityEngine;
using System.Collections;

public class KillDave : BossDave {
    public BossDave dave;
    

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            dave.hp --;
            if(dave.hp == 2)
            {
            // dave.attackSpeed =   dave.attackSpeed * 0.5f;
            }
            Destroy(gameObject);

        }
    }
}
