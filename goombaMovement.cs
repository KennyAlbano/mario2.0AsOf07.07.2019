using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombaMovement : MonoBehaviour {

	public GameObject goomba;
	bool hitWall = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if hit wall rotate 180 degrees
		//always move forward

		goomba.transform.Translate (0.1f, 0, 0);

		RaycastHit2D hit;
		hit = Physics2D.Raycast (goomba.transform.position + new Vector3(2f, 0,0), Vector2.right, 0.1f);
		if (hit.collider != null) 
		{
			hitWall = true;
		}

		hit = Physics2D.Raycast (goomba.transform.position + new Vector3(-2f, 0,0), Vector2.right, 0.1f);
		if (hit.collider != null) 
		{
			hitWall = true;
		}

		if (hitWall == true) 
		{
			goomba.transform.Rotate (0, 180, 0);
			hitWall = false;
		}			
	}
}
