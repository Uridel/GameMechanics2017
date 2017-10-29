using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BossDave : MonoBehaviour {

    public AudioSource randomSound;
    public AudioClip[] Daves;
    public bool isFighting = false;
    public float time;
    public float shootTimer;
    public int hp = 4;
    public float attackSpeed = 4;
    public float attackFaster = 2;

    public Object projectile;
    private Vector3 direction;
    public GameObject Playerobj;

    // Use this for initialization
    void Start () {
        Playerobj = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
           
        if (isFighting) {
            shootTimer += Time.deltaTime;
            time += Time.deltaTime;
            if (shootTimer >= attackSpeed)
            {
                Fire();
                shootTimer = 0;
            }
           
            if (!randomSound.isPlaying && time > 5)
            {

                CallAudio();
                time = 0;
            }
        }
        if(hp <= 2)
        {
            attackSpeed = attackFaster;       
            Debug.Log(attackSpeed);
        }
        if (hp <= 0)
        {
            SceneManager.LoadScene("win");
        }


	}

   
 
    void RandomSoundness()
    {
        randomSound.clip = Daves[Random.Range(0, Daves.Length)];
        randomSound.Play();

    }

    void CallAudio()
    {
        Invoke("RandomSoundness", 5);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Player")
        {
            isFighting = true;
           


        }
    }

    void Fire()
    {
       GameObject clone;
       direction = Playerobj.transform.position - transform.position;
       clone =  Instantiate(projectile, transform.position, transform.rotation) as GameObject;
       clone.GetComponent<Rigidbody2D>().velocity = direction.normalized * 10;
       

    }
}
