using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour {
	public float timeToDestroy = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Destroy (gameObject, timeToDestroy);

	}
	void OnTriggerEnter(Collider other){
		//if the player's bullet collides with a tag "enemy" then...
		if (other.gameObject.tag == "Enemy"){
			Debug.Log("We have hit the enemy");
			//Destroy(other.gameObject); destroy our enemy object
			Destroy(gameObject);//destroys bullet
}
	}
}