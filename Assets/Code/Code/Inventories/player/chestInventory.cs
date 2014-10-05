using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class chestInventory : MonoBehaviour {

	public List<inventory> chestInv = new List<inventory>();
	public chestGUI chestGUI;
	public ItemManager iManager;
	public Entities checkingEntities;
	public bool canOpen;
	public bool isOpen;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


		if (Vector2.Distance (rigidbody2D.transform.position, checkingEntities.rigidbody2D.transform.position) < 3)
		{
			canOpen = true;
		} 
		else 
		{
			canOpen = false;
		}

		if (canOpen == true) 
		
				{
					if (Input.GetKeyDown (KeyCode.E)) 
						{
							toggleChest();		
						}

				}
	}

	public void addToItemInventory(int itemId, int amount)
	{
 		for (int i = 0; i < iManager.items.Count; i++) {
			
			if(iManager.items[i].itemTransform.GetComponent<Item>().id == itemId)
			{
				inventory inv = new inventory(iManager.items[i].itemTransform.GetComponent<Item>(),amount);
				//items.Add (iManager.items[i].itemTransform.GetComponent<Item>());
				chestInv.Add(inv);
				
			}
			
		}



	}

	public void toggleChest()
	{

		if (!isOpen) {
						chestGUI.drawInventory = true;
						chestGUI.giveInventory (chestInv);
				} else 
		{
			chestGUI.drawInventory = false;	
		}
		isOpen = !isOpen;
		}


}
