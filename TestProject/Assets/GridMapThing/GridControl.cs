using UnityEngine;
using System.Collections;

public class GridControl : MonoBehaviour 
{
	// This is all fucked, I'll fix it later !!LOL!!

	/*
	private Transform from;
	private Transform to;
	void Update () 
	{
		// Rotates the vehicle around, it's forward and back rather than left and right for the rotation but w/e.
		if (Input.GetButtonDown("Turn")) 
		{
			//Quaternion.Euler(new Vector3(0, 0, transform.rotation.eulerAngles.z+90));
			//transform.rotation = Quaternion.Lerp(, to.rotation, Time.time);
			//gameObject.transform.Rotate(Input.GetAxisRaw("Turn")*Vector3.up*90);
		}
		if (Input.GetButtonDown("Accelerate")) 
		{
			StartCoroutine move()	
		}
			//gameObject.transform.Lerp(Input.GetAxisRaw("Accelerate")*Vector3.right);
		}
	}

	IEnumerator move (Transform target)
	{
		while(Vector3.Distance(transform.position, target.position) > 0.05f)
		{
			transform.position = Vector3.Lerp(transform.position, target.position, 0.1f * Time.deltaTime);
			
			yield return null;
		}
		
		print("Reached the target.");
		
		yield return new WaitForSeconds(3f);
		
		print("MyCoroutine is now finished.");
	}*/
}

