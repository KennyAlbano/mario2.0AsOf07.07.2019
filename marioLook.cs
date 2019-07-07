using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT CONTROLS THE SPRITE ANIMATIONS FOR MARIO

public class marioLook : MonoBehaviour {

	//0......1....2.....3......4.....5.....6.....7
	//front back left right Jfront Jback Jleft Jright
	public Sprite[] sprites;

	public GameObject mario;

	// Update is called once per frame
	void Update () {
		//changes sprite to front
		//spriterenderer.sprite = sprites[0];

		//if press left and not press right and not press up then sprites[2] LEFT  				+L-R-U=L2
		//if not press left and press right and not press up then sprites[3] RIGHT				-L+R-U=R3
		//if not press left and not press right and not press up then front sprites[0] FRONT 	-L-R-U=F0
		//if not press left and not press right and press up then sprites[4] JFRONT				-L-R+U=JF4
		//if press left and not press right and press up then sprites[6] JLEFT					+L-R+U=JL6
		//if not press left and press right and press up then sprites[7] JRIGHT					-L+R+U=JR7

		mario.GetComponent<SpriteRenderer> ().sprite = sprites [2];


		//look Left 
		if ((Input.GetKey (KeyCode.LeftArrow)) && !(Input.GetKey (KeyCode.RightArrow)) && !(Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [2];
		}

		//look Right 
		if (!(Input.GetKey (KeyCode.LeftArrow)) && (Input.GetKey (KeyCode.RightArrow)) && !(Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [3];
		}

		//look Front 
		if (!(Input.GetKey (KeyCode.LeftArrow)) && !(Input.GetKey (KeyCode.RightArrow)) && !(Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [0];
		}

		//look Jump Front 
		if (!(Input.GetKey (KeyCode.LeftArrow)) && !(Input.GetKey (KeyCode.RightArrow)) && (Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [4];
		}

		//look Jump Left
		if ((Input.GetKey (KeyCode.LeftArrow)) && !(Input.GetKey (KeyCode.RightArrow)) && (Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [6];
		}

		//look Jump Right
		if (!(Input.GetKey (KeyCode.LeftArrow)) && (Input.GetKey (KeyCode.RightArrow)) && (Input.GetKey (KeyCode.UpArrow))) 
		{
			mario.GetComponent<SpriteRenderer> ().sprite = sprites [7];
		}
	}
}
