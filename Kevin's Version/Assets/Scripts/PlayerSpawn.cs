using UnityEngine;
using System.Collections;

public class PlayerSpawn : MonoBehaviour {

	private GameObject blueTriangle;
	private Transform RBC2;
	public Transform spawnPoint;
	public float respawnTime=4;

	// Use this for initialization
	void Start () {
		playerSpawn (0, -1);
		//blueTriangle.transform.Rotate (Vector3.forward * 180);
	}
	
	// Update is called once per frame
	void Update () {
		if (blueTriangle == null) {
			respawnTime -= Time.deltaTime;
			if (respawnTime<=0){
				playerSpawn (0, -1);
				respawnTime=4;
			}
		}
	}

	void playerSpawn(float x, float y){
		Vector3 spawnPointPosition = spawnPoint.transform.position;
		spawnPointPosition.y += y;
		blueTriangle = (GameObject) Instantiate (Resources.Load("Blue Triangle"), spawnPointPosition, spawnPoint.rotation);
		Vector3 RBC2Position = blueTriangle.transform.position; 
		RBC2Position.x -= 0.315f; RBC2Position.y -= 0.1575f; 
		RBC2 = ((GameObject) Instantiate (Resources.Load ("RB2C"), RBC2Position, blueTriangle.transform.rotation)).transform;
		RBC2.parent = blueTriangle.transform;
	}
}
