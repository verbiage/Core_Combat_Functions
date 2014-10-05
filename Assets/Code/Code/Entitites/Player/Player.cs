using UnityEngine;
using System.Collections;

public class Player : Entities {

	public ItemPlayer ipManager;

	void Start () {
		ipManager.addToItemInventory(0,5);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) 
		{
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) 
		{
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;

		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;

		}
		if (health <= 0)
		{
			Die();		
		}

	}
	public void Die()
	{
		print ("I've been killed");
		Debug.Break ();
	}
}
