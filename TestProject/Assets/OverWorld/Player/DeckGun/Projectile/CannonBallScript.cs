using UnityEngine;
using System.Collections;

public class CannonBallScript : MonoBehaviour 
{	
	private GameObject deckGun;
	private Transform position;
	public float speed = 100f;
	private float lifetime = 80f;	

	void Start () 
	{
		deckGun = GameObject.FindWithTag("gun");
		position = deckGun.transform;
		gameObject.transform.rotation = position.rotation;
		gameObject.transform.position = position.position;
		gameObject.transform.position += Vector3.forward * 10f;
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
