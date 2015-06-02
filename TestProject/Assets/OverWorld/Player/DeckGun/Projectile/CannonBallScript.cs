using UnityEngine;
using System.Collections;

public class CannonBallScript : MonoBehaviour 
{	
	private GameObject deckGun;
	private Transform myTransform;
	private float speed = 50f;
	private float lifetime = 120f;	
	// Spawns at the front of the gun with the correct rotation, There's definitely a better way to do this, I just need to get around to it.
	// First idea is to create an empty to be hte casting point and have that handle the event rather than the gun.
	void Start () 
	{
		deckGun = GameObject.FindWithTag("gun");
		myTransform = deckGun.transform;
		gameObject.transform.rotation = myTransform.rotation;
		gameObject.transform.position = myTransform.position;
		gameObject.transform.position += Vector3.forward * 0f;
		gameObject.transform.position = new Vector3 (transform.position.x, transform.position.y, -5f);
	}

	void FixedUpdate () 
	{
		// Needs proper motion implementing, like an actual projectile.
		if (lifetime == 0) 
		{
			Destroy(gameObject);
		}
		lifetime --;
		gameObject.transform.Translate(Vector3.up * speed * Time.fixedDeltaTime);
	} 
}
