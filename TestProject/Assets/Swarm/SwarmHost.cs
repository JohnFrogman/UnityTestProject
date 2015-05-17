using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SwarmHost : MonoBehaviour 
{
	public GameObject SwarmerPrefab;
	public int population = 5;
	public float inertia = 0.9f;
	public float cognitive = 0.9f;
	public float social = 0.9f;
	public float mutation = 0.9f;
	public float maxVelocity = 10;
	private Vector2 gbest;
	private Vector2 optima;
	private GameObject player;
	private GameObject[] swarm;
	
	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");
		swarm = new GameObject[population];
		for (int i = 0; i<population; i++)
		{
			var temp = Instantiate(SwarmerPrefab, transform.position, Quaternion.identity) as GameObject;
			swarm[i] = temp; 
		}
		getGbest ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		optima = (Vector2)player.transform.position;
		getGbest ();
		updateVelocities ();
		
		
	}
	private void getGbest()
	{
		gbest = (optima-(Vector2)swarm[0].transform.position);
		foreach (GameObject member in swarm)
		{
			if ((optima-(Vector2)member.transform.position).magnitude < (optima-gbest).magnitude)
			{
				gbest = member.transform.position;
			}
			
		}
	}
	
	private void updateVelocities()
	{
		foreach (GameObject member in swarm)
		{
			Swarmer script = (Swarmer)member.GetComponent(typeof(Swarmer));
			script.updateVelocity(gbest, optima, maxVelocity);
		}
	}
}