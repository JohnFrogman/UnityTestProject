using UnityEngine;
using System.Collections;
using System;


public class Control : MonoBehaviour {
	public float maxSpeed = 50; 
	public float acceleration = 2;
	public float turnRate = 3;
	// Coefficient that controls the speed of the break, this must always be less than 1
	// If it's too low then the player will struggle to come to a halt at all, too high and it
	// feels silly. Above one and it bugs out.
	public float brakepower = 0.1F;
	public float speed;
	
	void Update () 
	{
		// Rotates the vehicle around, it's forward and back rather than left and right for the rotation but w/e.
		if (Input.GetButton("Turn")) 
		{
			gameObject.transform.Rotate(Input.GetAxisRaw("Turn")*turnRate*Vector3.forward*Time.deltaTime);
		}
		if (Input.GetButton ("Accelerate")) 
		{
			// Stops you breaking the speed limit, for both forward and reverse.
			if (speed*Input.GetAxisRaw("Accelerate") < maxSpeed)
			{
				speed += Input.GetAxisRaw("Accelerate")*acceleration*Time.deltaTime;
			}
		}
		// Exponentially decaying function
		if (Input.GetButton ("Brake")) 
		{
			if (speed < 1)
			{
				speed = 0;
			}
			else
			{
				speed -= brakepower*speed;
			}
		}

		if (Input.GetButtonDown ("Pause")) 
		{
			if (Time.timeScale == 1) 
			{
				Time.timeScale = 0;
			} 
			else 
			{
				Time.timeScale = 1;
			}
		}
			// The current speed.
		gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
	}

	// A load of shit that doesn't work
	void OnControllerColliderHit(ControllerColliderHit hit) 
	{
		Debug.Log ("hit");
	}

	void OnCollisionEnter(Collision hit)
	{
		if(hit.gameObject)
		{
			speed-=1;
		}
	}

}
