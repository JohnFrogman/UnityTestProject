using UnityEngine;
using System.Collections;

public class Swarmer : MonoBehaviour 
{
	//private Vector3 spawnPosition = new Vector3();
	private Vector2 pBest;
	public Vector2 offset = new Vector2();
	public Vector2 velocity = new Vector2();
	private float inertia;
	private float cognitive;
	private float social;
	private float mutation;
	private SwarmHost script;
	private GameObject host;

	public void updateVelocity(Vector3 gbest, Vector3 optima, float maxVelocity)
	{
		getpBest ((Vector2)optima);
		velocity = 	(inertia*velocity 
			 		+ Random.value*cognitive*((Vector2)pBest - (Vector2)transform.position)
			 		+ Random.value*social*((Vector2)gbest - (Vector2)transform.position))
					+ Random.value*mutation*(Random.insideUnitCircle);
	}

	public Vector2 getPosition()
	{
		return (Vector2)transform.position;
	}
	// Use this for initialization
	void Start () 
	{
		host = GameObject.FindGameObjectWithTag("SwarmHost");

		script  = (SwarmHost)host.GetComponent(typeof(SwarmHost));
		inertia =  script.inertia;
		cognitive = script.cognitive;
		social = script.social;
		mutation = script.mutation;
	}
	void getpBest(Vector2 optima)
	{
		if (pBest == null) 
		{
			pBest = optima-(Vector2)transform.position;
		}
		else
		{
			if ((optima-pBest).magnitude > (optima - (Vector2)transform.position).magnitude)
			{
				pBest = transform.position;
			}
		}
	}
	// Update is called once per frame
	void Update () 
	{
		transform.position += (Vector3)velocity;
	}
}
