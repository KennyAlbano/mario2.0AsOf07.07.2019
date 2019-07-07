using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT CONTROLS MARIO's MOVEMENT

public class marioBehavior : MonoBehaviour {

	float velocityX = 0;
	public float velocityY = 0;
	public bool grounded = true;
	float FasterX = 1;
	public GameObject mario;
	public int numberOfJumps = 0;

	// Update is called once per frame
	void Update () {

		AudioSource marioJumpSound = mario.GetComponent<AudioSource> ();


		//move left
		if (Input.GetKeyDown (KeyCode.LeftArrow) ) 
		{
			velocityX = -.3f;
		}

		//move Right 
		if (Input.GetKeyDown (KeyCode.RightArrow))
		{
			velocityX = .3f;
		}

		//dont move Horizontal -if not pressing left or right button then dont move mario left or right
		if (!(Input.GetKey (KeyCode.LeftArrow)) && !(Input.GetKey (KeyCode.RightArrow)))
		{
			velocityX = 0f;
		}

		//Jump -numberOfJumps controls how many jumps mario can make before landing --8 jumps allows for single or double jump but not triple jump when jump ability set to 0.6 
		if ((Input.GetKey (KeyCode.UpArrow)) && ((velocityY <= 0.5f)) && (numberOfJumps <= 9))
		{
			velocityY = velocityY + 0.7f;
			grounded = false;
			marioJumpSound.Play ();
		}

		//checks if there is a solid surface beneath mario and if none then set variable grounded to false 
		RaycastHit2D hit = Physics2D.Raycast (transform.position - new Vector3(0f,3f,0f), -Vector2.up, 0.00001f);
		if(hit.collider == null)	
		{
			grounded = false;
		}

		//if no solid surface directly below mario then mario falls
		if ((grounded == false) && (velocityY > -0.5f))
		{
			velocityY = velocityY - 0.1f;
		}

		//if there is a solid surface under mario and user is not pressing jump then neither jump or fall
		if (!(Input.GetKey (KeyCode.UpArrow)) && grounded == true)
		{
			velocityY = 0f;
		}

		//if there is solid under mario then grounded is set to true
		if(hit.collider != null)	
		{
			grounded = true;
		}

		//controls actual movement ************************************************* Actual movement 
		transform.Translate(velocityX, velocityY, 0);

		//mario's jumping ability is depleted by holding down up which also makes mario jump higher
		if (Input.GetKeyDown (KeyCode.UpArrow) || velocityY > 0.6f)
		{
			numberOfJumps = numberOfJumps + 1;
		}
		//resets jumping ability when mario is on the ground
		if (grounded == true)
		{
			numberOfJumps = 0;
		}




	}
}
