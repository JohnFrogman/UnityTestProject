using UnityEngine;
using System.Collections;

public class Enter : MonoBehaviour 
{
	public GameObject townUi;
	public int[] goods = new int[10];
	public string townname = "default";
	public string subtitle = "default";
	public string descLocation = "default";

	// Basic idea here is to generate a gui with all the town details on from the information above.
	void OnTriggerStay2D(Collider2D other)
	{
		if (Input.GetButtonDown ("Dock")) 
		{
			if (Time.timeScale == 1) 
			{
				Time.timeScale = 0;
				townUi.SetActive (true);
				LoadTown town = (LoadTown)townUi.GetComponent(typeof(LoadTown));
				town.load(townname, subtitle, descLocation, goods);

				// for each goods in good that doesnt have an element of value -1 put a new good in and set it's price to whatever
			} 
		}
	}
}
