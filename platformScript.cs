using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformScript : MonoBehaviour {

	//if pressing up or down dont stop player
	//if not pressing up and not pressing down stop player
	//public bool solid = platform.GetComponent<BoxCollider2D>().enabled;
	public GameObject platform;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.DownArrow))
		{
			platform.GetComponent<BoxCollider2D> ().enabled = false;
		} 
		if(Input.GetKeyUp(KeyCode.DownArrow))
		{
			platform.GetComponent<BoxCollider2D> ().enabled = true;
		}
	}
}
