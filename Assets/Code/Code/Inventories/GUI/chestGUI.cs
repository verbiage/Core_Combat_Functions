using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class chestGUI : MonoBehaviour {

	public GUISkin guiSkin;

	public List<inventory> chestInv = new List<inventory>();

	public bool drawInventory;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onGUI()
	{
		if (drawInventory) 
		
		{
				
		}

	}

	public void giveInventory(List<inventory> i)
	{
		this.chestInv = i;
	
	}


}
