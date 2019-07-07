using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//THIS SCRIPT MOVES THE CAMERA WITH THE PLAYER

public class cameraView : MonoBehaviour {

	public GameObject camera;
	public GameObject player;
	public GameObject sun;
	public GameObject cloud;
	public GameObject cloud2;
	public GameObject cloud3;
	public GameObject cloud4;
	public GameObject cloud5;
	public GameObject cloud6;

	// Update is called once per frame
	void Update () 
	{
		camera.transform.position = player.transform.position + new Vector3 (0f, 0f, -10f);
		sun.transform.position = camera.transform.position + new Vector3 (-15f, 20f, 20f);
		cloud.transform.position = cloud.transform.position + new Vector3 (0.01f, 0f, 0f);
		cloud2.transform.position = cloud2.transform.position + new Vector3 (0.1f, 0f, 0f);
		cloud3.transform.position = cloud3.transform.position + new Vector3 (0.05f, 0.005f, 0f);
		cloud4.transform.position = cloud4.transform.position + new Vector3 (0.1f, 0f, 0f);
		cloud5.transform.position = cloud5.transform.position + new Vector3 (0.006f, 0f, 0f);
		cloud6.transform.position = cloud6.transform.position + new Vector3 (0.03f, 0.005f, 0f);
	}
}
