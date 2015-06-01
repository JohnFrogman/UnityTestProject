using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour 
{
	public GameObject projectile;

	private bool active;
	public Vector3 p;
	public Vector3 q;

	public Vector3 direction;
	public Quaternion lookRotation;

	public Camera camera;
	public float deadzone = 10f;
	public float turnRate = 1f;
	// Use this for initialization
	void Start () 
	{
		active = false;
	}

	void Update () 
	{

		if (Input.GetButtonDown ("ActivateTurret")) 
		{
			active = !active;
		}

		if (active)
		{
			if (Input.GetButtonDown ("Fire") ) 
			{
				Instantiate(projectile);
			}

			q = (Vector3)Input.mousePosition;
			q.z = transform.position.z;
			p = camera.ScreenToWorldPoint(q);

			/*
			direction = (p - transform.position).normalized;
			lookRotation = Quaternion.LookRotation(direction);
			transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnRate);		
			*/
			/*
			Vector3 direction = p - transform.position;
			Quaternion toRotation = Quaternion.FromToRotation(direction, Vector3.back);
			transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, turnRate * Time.time);
			*/

			transform.LookAt(p, Vector3.back);

		}
	}
}
