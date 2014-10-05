using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour {

	private GameObject[] redTriangle = new GameObject[2];
	public Transform[] RBC2 = new Transform[2];
	public Transform redTriangleSpawn;

	// Use this for initialization
	void Start () {
		for (int i=0; i<2; i++) {
			redTriangle[i] = (GameObject) Instantiate (Resources.Load("Red Triangle"), redTriangleSpawn.position, redTriangleSpawn.rotation);
			Vector3 RBC2Position = redTriangle[i].transform.position; 
			RBC2Position.x -= 0.315f; RBC2Position.y -= 0.1575f; 
			RBC2[i] = ((GameObject) Instantiate (Resources.Load ("RB2C"), RBC2Position, redTriangle[i].transform.rotation)).transform;
			RBC2[i].parent = redTriangle[i].transform;
			redTriangle[i].transform.Rotate (Vector3.forward * 180);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
