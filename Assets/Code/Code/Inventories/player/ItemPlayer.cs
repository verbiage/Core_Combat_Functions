using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemPlayer : MonoBehaviour {

	public ItemManager iManager;
	//public Transform iSpawnTransform;
	public List<inventory> items = new List<inventory>();
	void Start () {
	
	}
	

	void Update () {
	


	}

	public void addToItemInventory(int itemId, int amount)
	{
		for (int i = 0; i < iManager.items.Count; i++) {
				
			if(iManager.items[i].itemTransform.GetComponent<Item>().id == itemId)
			{
				inventory inv = new inventory(iManager.items[i].itemTransform.GetComponent<Item>(),amount);
				//items.Add (iManager.items[i].itemTransform.GetComponent<Item>());
				items.Add(inv);

			}
		
		}


	}
}

[System.Serializable]
public class inventory
{


	public Item item;
	public int amountOfItem;

	public inventory(Item item, int amountofItem)
	{

		this.item = item;
		this.amountOfItem = amountofItem; 
	}
}
