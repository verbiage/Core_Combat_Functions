using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			//transform.Translate(Vector2.right * speed);
			//transform.position += Vector3.right * speed;
			//rigidbody2D.AddForce(Vector2.right);
			//rigidbody2D.velocity = Vector2.right;
			transform.Rotate(Vector3.back * Time.deltaTime * 180);
		}
		if (Input.GetKey (KeyCode.A)) {
			//transform.Translate(-Vector2.right * speed);
			transform.Rotate(Vector3.forward * Time.deltaTime * 180);
		}
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate(Vector2.up * speed);
			//rigidbody2D.AddForce(Vector2.up);
		}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate(-Vector2.up * speed);
			//rigidbody2D.AddForce(-Vector2.up);
		}
		if (Input.GetKey (KeyCode.E)) {
			transform.Translate(Vector2.right * speed);
			//rigidbody2D.AddForce(Vector2.right);
		}
		if (Input.GetKey (KeyCode.Q)) {
			transform.Translate(-Vector2.right * speed);
			//rigidbody2D.AddForce(-Vector2.right);
		}
	}
}
