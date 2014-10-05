using UnityEngine;
using System.Collections;

public class FollowerMob : Entities {

	public Entities following;
	public float distance;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (following.rigidbody2D.transform.position.y > (rigidbody2D.transform.position.y + distance)) 	
		{
			rigidbody2D.transform.position += Vector3.up * speed * Time.deltaTime;
		}

		if (following.rigidbody2D.transform.position.y < (rigidbody2D.transform.position.y - distance)) 	
		{
			rigidbody2D.transform.position += Vector3.down * speed * Time.deltaTime;
		}

		if (following.rigidbody2D.transform.position.x > (rigidbody2D.transform.position.x + distance)) 	
		{
			rigidbody2D.transform.position += Vector3.right * speed * Time.deltaTime;
		}

		if (following.rigidbody2D.transform.position.x < (rigidbody2D.transform.position.x - distance)) 	
		{
			rigidbody2D.transform.position += Vector3.left * speed * Time.deltaTime;
			
		}
		if (health <= 0)
		{
			Die();		
		}

	}
	public void Die()
	{
		
	}
}
