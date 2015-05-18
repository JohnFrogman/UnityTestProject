using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LoadTown : MonoBehaviour 
{
	private int[] goods = new int[10];
	public GameObject title;
	public GameObject subtitle;
	public GameObject descriptionBox;

	public void load(string name, string subtitle, string descLocation, int[] goods)
	{
		title.GetComponent<Text>() = name;
		subtitle.GetComponent<Text>() = subtitle;
		// read in description via descLocation
		string description = "default";
		descriptionBox.GetComponent<Text>() = description; 
	}

	public void undock()
	{
		Time.timeScale = 1;
		gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
}
