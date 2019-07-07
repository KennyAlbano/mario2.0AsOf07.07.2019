using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bugJump : MonoBehaviour {

	public Sprite bugFront;
	public Sprite bugFrontJump;
	public int delay;
	public SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () 
	{
		spriteRenderer = GetComponent<SpriteRenderer> ();
		//if bug sprite is bugFront then wait 1 second then change sprite to bugFrontJump and move upwards then downwards
		//if bug sprite is bugFrontJump then wait 1 seconds then change sprite from bugFrontJump to bugFront
		InvokeRepeating ("changeToBugFrontJump", 1f / delay, 3f / delay);
		InvokeRepeating ("changeToBugFront", 2f / delay, 3f / delay);
	}

	void changeToBugFront()
	{
		spriteRenderer.sprite = bugFront;
		transform.Translate (0, -4, 0);
	}

	void changeToBugFrontJump()
	{
		spriteRenderer.sprite = bugFrontJump;
		transform.Translate (0, 4, 0);
	}
}
