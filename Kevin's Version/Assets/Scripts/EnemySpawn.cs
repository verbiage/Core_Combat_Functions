using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	private GameObject[] redTriangle = new GameObject[2];
	private Transform[] RBC2 = new Transform[2];
	public Transform spawnPoint;
	private float[] respawnTime = new float[2];

	// Use this for initialization
	void Start () {
		for (int i=0; i<2; i++) {
			respawnTime[i] = 4;
		}
		enemySpawn (0, 3);
	}
	
	// Update is called once per frame
	void Update () {
		for (int i=0; i<2; i++){
			if (redTriangle[i] == null) {
				respawnTime[i] -= Time.deltaTime;
				if (respawnTime[i]<=0){
					enemySpawn (0, 3, i);
					respawnTime[i]=4;
				}
			}
		}
	}

	void enemySpawn(float x, float y){
		Vector3 spawnPointPosition = spawnPoint.transform.position;
		spawnPointPosition.y += y;
		for (int i=0; i<2; i++) {
			redTriangle[i] = (GameObject) Instantiate (Resources.Load("Red Triangle"), spawnPointPosition, spawnPoint.rotation);
			Vector3 RBC2Position = redTriangle[i].transform.position; 
			RBC2Position.x -= 0.315f; RBC2Position.y -= 0.1575f; 
			RBC2[i] = ((GameObject) Instantiate (Resources.Load ("RB2C"), RBC2Position, redTriangle[i].transform.rotation)).transform;
			RBC2[i].parent = redTriangle[i].transform;
			redTriangle[i].transform.Rotate (Vector3.forward * 180);
		}
	}

	void enemySpawn(float x, float y, int i){
		Vector3 spawnPointPosition = spawnPoint.transform.position;
		spawnPointPosition.y += y;
		redTriangle[i] = (GameObject) Instantiate (Resources.Load("Red Triangle"), spawnPointPosition, spawnPoint.rotation);
		Vector3 RBC2Position = redTriangle[i].transform.position; 
		RBC2Position.x -= 0.315f; RBC2Position.y -= 0.1575f; 
		RBC2[i] = ((GameObject) Instantiate (Resources.Load ("RB2C"), RBC2Position, redTriangle[i].transform.rotation)).transform;
		RBC2[i].parent = redTriangle[i].transform;
		redTriangle[i].transform.Rotate (Vector3.forward * 180);
	}
}
