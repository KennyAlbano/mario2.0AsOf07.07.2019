using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badGuyHitsMario : MonoBehaviour {

	public GameObject mario;
	public GameObject sumo;
	public GameObject goomba;
	public GameObject bugz;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (mario.transform.position.x <= sumo.transform.position.x + 5 && mario.transform.position.x >= sumo.transform.position.x - 5
			&& mario.transform.position.y <= sumo.transform.position.y + 6 && mario.transform.position.y >= sumo.transform.position.y - 5) 
		{
			mario.transform.position = new Vector3(0,2,0);
		}

		if (mario.transform.position.x <= goomba.transform.position.x + 3 && mario.transform.position.x >= goomba.transform.position.x - 3
			&& mario.transform.position.y <= goomba.transform.position.y + 3 && mario.transform.position.y >= goomba.transform.position.y - 3) 
		{
			mario.transform.position = new Vector3(0,2,0);
		}

		if (mario.transform.position.x <= bugz.transform.position.x + 7 && mario.transform.position.x >= bugz.transform.position.x - 7
			&& mario.transform.position.y <= bugz.transform.position.y + 5.6 && mario.transform.position.y >= bugz.transform.position.y - 2) 
		{
			mario.transform.position = new Vector3(0,2,0);
		}
	}
}
