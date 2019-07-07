using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marioJumpsOnBadGuy : MonoBehaviour {

	public GameObject mario;
	public GameObject goomba;
	public GameObject bugz;
	public GameObject sumo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//if mario is directly above goomba destroy goomba
		if (mario.transform.position.x <= goomba.transform.position.x + 2 && mario.transform.position.x >= goomba.transform.position.x - 2
		    && mario.transform.position.y <= goomba.transform.position.y + 4.5 && mario.transform.position.y >= goomba.transform.position.y - 0) 
		{
			Destroy (goomba);
		}
		if (mario.transform.position.x <= bugz.transform.position.x + 2 && mario.transform.position.x >= bugz.transform.position.x - 2
			&& mario.transform.position.y <= bugz.transform.position.y + 7 && mario.transform.position.y >= bugz.transform.position.y - 0) 
		{
			Destroy (bugz);
		}
		if (mario.transform.position.x <= sumo.transform.position.x + 2 && mario.transform.position.x >= sumo.transform.position.x - 2
			&& mario.transform.position.y <= sumo.transform.position.y + 7 && mario.transform.position.y >= sumo.transform.position.y - 0) 
		{
			Destroy (sumo);
		}
	}
}
