using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//sumo should wait xSeconds
//Then sumo should rotate z axis back and forth 10 and -10 degrees
//Then sumo should jump down
//then wait for xSeconds
//then rotate back and forth again
//then jump up
//then repeat

//functions - waitXSecondsFunct, rotateFunct, jumpDownFunct, jumpUpFunct, loop everything in update
public class sumoScript : MonoBehaviour {
	public int ssmod;
	public float rotateXDegrees = 10f;
	public GameObject sumo;
	//jumpHeight should be determined case by case in editor therefore should be public varibale 
	//waitTime should be set and used in waitXSecondsFunct
	//rotateXDegrees should be a constant int = 10
	void Start()
	{
		InvokeRepeating ("rotateFunctCounterClockwise", 1f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctClockwise", 2f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctClockwise", 3f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctCounterClockwise", 4f/ssmod, 11f/ssmod);
		InvokeRepeating ("jumpDownFunct", 5f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctCounterClockwise", 6f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctClockwise", 7f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctClockwise", 8f/ssmod, 11f/ssmod);
		InvokeRepeating ("rotateFunctCounterClockwise", 9f/ssmod, 11f/ssmod);
		InvokeRepeating ("jumpUpFunct", 10f/ssmod, 11f/ssmod);
	}

	void rotateFunctCounterClockwise()
	{
		sumo.transform.Rotate (0, 0, rotateXDegrees);
	}

	void rotateFunctClockwise()
	{
		sumo.transform.Rotate (0, 0, -rotateXDegrees);
	}

	public void jumpDownFunct()
	{
		sumo.transform.Translate (0, -22, 0);
	}

	public void jumpUpFunct()
	{
		sumo.transform.Translate (0, 22, 0);
	}

}
