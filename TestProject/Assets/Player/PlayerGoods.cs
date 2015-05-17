using UnityEngine;
using System.Collections;

public class PlayerGoods : MonoBehaviour 
{
	// WORK IN PROGRESS NOTHING HERE IS FINAL ITS JUST STUFF I SHIT OUT IN FIVE MINUTES WITHOUT THINKING
	private int[] tradeGoods = new int[10];
	private int money;

	public int[] TradeGoods
	{
		get
		{
			return tradeGoods;
		}
		set
		{
			tradeGoods = value;
		}
	}

	public int Money
	{
		get 
		{
			return money;
		}
		set
		{
			money = value;
		}
	}


	void Awake()
	{
		//buy = town.GetComponent<EnterTown>()
	}
	void Start () 
	{
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
