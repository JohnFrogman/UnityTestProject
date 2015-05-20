﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Enter : MonoBehaviour 
{
	public GameObject townUi;
	public GameObject dockButton;
	public int[] goods = new int[10];
	public string townname = "default";
	public string subtitle = "default";
	public string townID = "default";


	void OnTriggerEnter2D(Collider2D other)
	{
		dockButton.SetActive (true);
	}
	void OnTriggerExit2D(Collider2D other)
	{
		dockButton.SetActive (false);
	}
	// Basic idea here is to generate a gui with all the town details on from the information above.
	// This is unresponsive 
	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetButtonDown ("Dock")) 
		{
			if (Time.timeScale == 1) 
			{
				dockButton.SetActive (false);
				Time.timeScale = 0;
				townUi.SetActive (true);
				LoadTown town = (LoadTown)townUi.GetComponent(typeof(LoadTown));
				town.load(townname, subtitle, townID, goods);

				// for each goods in good that doesnt have an element of value -1 put a new good in and set it's price to whatever
			} 
		}
	}
}
