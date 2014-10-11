using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform target;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Blue Triangle(Clone)") != null) {
			target = GameObject.Find ("Blue Triangle(Clone)").transform;
			transform.position = target.position + new Vector3 (0, 0, -10);
		}
	}
}
