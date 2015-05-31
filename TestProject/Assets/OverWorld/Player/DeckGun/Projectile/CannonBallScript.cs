using UnityEngine;
using System.Collections;

public class CannonBallScript : MonoBehaviour 
{	
	public float fallSpeed = 30f;
	public float speed = 50f;
	public Vector3 initialDirection;	
	void Start () 
	{

	}
	void FixedUpdate () 
	{
		// Needs proper motion implementing, like an actual projectile.
		if (transform.position.z > 350f) 
		{
			Destroy(gameObject);
		}
		gameObject.transform.Translate(Vector3.down * fallSpeed * Time.fixedDeltaTime);
		gameObject.transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime);
	} 
}
