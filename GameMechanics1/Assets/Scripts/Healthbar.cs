using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	public Sprite fullHealth, halfHealth, fullerHealth;
	private Sprite PrevColor;
	private SpriteRenderer spriteRenderer;
	public static PlayerControl playerControl;



	// Use this for initialization
	void Start () {
		playerControl = FindObjectOfType<PlayerControl> ();
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = fullHealth; // set the sprite to sprite1
			PrevColor = fullHealth;
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (playerControl.playerLives == 2)//becomes a color
		{
			//ColorTimer = 0;
			ChangeTheDamnSprite(halfHealth, fullHealth );
			
			//colorNumber = 1;
			
		}
        if (playerControl.playerLives == 1) {
			ChangeTheDamnSprite(fullHealth, halfHealth);
		}
        if (playerControl.playerLives == 3)
        {
            moreLives(fullHealth, fullerHealth);
        }

	}

	void ChangeTheDamnSprite(Sprite fullHealth, Sprite halfHealth)
	{
		if (spriteRenderer.sprite == fullHealth) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = halfHealth;
		}
		else
		{
			spriteRenderer.sprite = halfHealth; // otherwise change it back to sprite1
		}
	}
    void moreLives(Sprite fullHealth, Sprite fullerHealth)
    {
        if (spriteRenderer.sprite == fullHealth) // if the spriteRenderer sprite = sprite1 then change to sprite2
        {
            spriteRenderer.sprite = fullerHealth;
        }
        else
        {
            spriteRenderer.sprite = fullerHealth; // otherwise change it back to sprite1
        }
    }

}
