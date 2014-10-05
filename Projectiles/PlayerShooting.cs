using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public Rigidbody2D shotPrefab;
	public float attackSpeed = .5f;
	public float cooldown;
	public float shotSpeed = 200f;
	float yValue = .75f;
	float xValue = .5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Time.time >= cooldown) {
						if (Input.GetKey (KeyCode.RightArrow)) {
								FireRight ();
						}
				}
				if (Time.time >= cooldown) {
						if (Input.GetKey (KeyCode.LeftArrow)) {
								FireLeft ();
						}
				}

				if (Time.time >= cooldown) {
						if (Input.GetKey (KeyCode.UpArrow)) {
								FireUp ();
						}
				}

				if (Time.time >= cooldown) {
						if (Input.GetKey (KeyCode.DownArrow)) {
								FireDown ();
						}
				}
			}

	void FireRight(){
		//Rigidbody2D shotPrefabClone = (Rigidbody2D) Instantiate (shotPrefab, transform.position, Quaternion.identity);
		Rigidbody2D shotPrefabClone = (Rigidbody2D)Instantiate (shotPrefab, new Vector3 (transform.position.x + xValue, transform.position.y, transform.position.z), Quaternion.identity);
		shotPrefabClone.rigidbody2D.AddForce (Vector3.right * shotSpeed);
						cooldown = Time.time + attackSpeed;}

	void FireLeft(){
		//Rigidbody2D shotPrefabClone = (Rigidbody2D) Instantiate (shotPrefab, transform.position, Quaternion.identity);
		Rigidbody2D shotPrefabClone = (Rigidbody2D)Instantiate (shotPrefab, new Vector3 (transform.position.x - xValue, transform.position.y, transform.position.z), Quaternion.identity);
		shotPrefabClone.rigidbody2D.AddForce (Vector3.left * shotSpeed);
						cooldown = Time.time + attackSpeed;}

	void FireUp(){
		//Rigidbody2D shotPrefabClone = (Rigidbody2D)Instantiate (shotPrefab, transform.position, Quaternion.identity);
		Rigidbody2D shotPrefabClone = (Rigidbody2D)Instantiate (shotPrefab, new Vector3 (transform.position.x, transform.position.y + yValue, transform.position.z), Quaternion.identity);
		shotPrefabClone.rigidbody2D.AddForce (Vector3.up * shotSpeed);
						cooldown = Time.time + attackSpeed;}

	void FireDown(){
		//Rigidbody2D shotPrefabClone = (Rigidbody2D) Instantiate (shotPrefab, transform.position, Quaternion.identity);
		Rigidbody2D shotPrefabClone = (Rigidbody2D)Instantiate (shotPrefab, new Vector3 (transform.position.x, transform.position.y - yValue, transform.position.z), Quaternion.identity);
		shotPrefabClone.rigidbody2D.AddForce (Vector3.down * shotSpeed);
						cooldown = Time.time + attackSpeed;}
}