using UnityEngine;
using System.Collections;

public class DayNightCycle : MonoBehaviour 
{
	public float timeflow = 1f;
	void Update () 
	{
		gameObject.transform.Rotate(timeflow*Vector3.left*Time.deltaTime);
	}
}
