using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour 
{
	void Update () 
	{
		// Rotates the vehicle around, it's forward and back rather than left and right for the rotation but w/e.
		if (Input.GetButtonDown("Turn")) 
		{
			gameObject.transform.Rotate(Input.GetAxisRaw("Turn")*Vector3.up*90);
		}
		if (Input.GetButtonDown("Accelerate")) 
		{
			gameObject.transform.Translate(Input.GetAxisRaw("Accelerate")*Vector3.right);
		}
	}
}
