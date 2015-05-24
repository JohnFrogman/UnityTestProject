using UnityEngine;
using System.Collections;

public class TurretControl : MonoBehaviour 
{
	private bool active;
	public Vector3 p;
	public Camera camera;
	public float deadzone = 10f;
	public float turnRate = 0.1f;
	// Use this for initialization
	void Start () 
	{
		active = false;
	}

	void Update () 
	{
		// p = camera.ScreenToWorldPoint(Input.mousePosition);
		// p.z = 0;

		p = Input.mousePosition;
		p.x -= Screen.width/2f;
		p.y -= Screen.height/2f;
		p.z = transform.position.z;

		if (Input.GetButtonDown ("ActivateTurret")) 
		{
			active = !active;
		}

		if (active && ((Vector2)p - (Vector2)transform.position).magnitude > deadzone ) 
		{
			transform.LookAt(transform.position + p, Vector3.back);
		}
	}
}
