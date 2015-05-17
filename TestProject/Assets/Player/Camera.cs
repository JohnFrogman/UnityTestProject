using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour 
	{
	private float x;
	private float y;
	private GameObject focus;
	// Use this for initialization
	void Start () 
	{
		focus = GameObject.FindGameObjectWithTag ("Player");
		x = focus.transform.position.x;
		y = focus.transform.position.y;
	}
	// The camera is just fixed to the player.
	// Update is called once per frame
	void Update () 
	{
		x = GameObject.FindGameObjectWithTag("Player").transform.position.x;
		y = GameObject.FindGameObjectWithTag("Player").transform.position.y;
		gameObject.transform.position = new Vector3 (x, y, -20);
	}
}
