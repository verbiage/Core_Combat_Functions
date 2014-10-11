using UnityEngine;
using System.Collections;

public class Status : MonoBehaviour {
	
	public float health = 100f;
	public float healthRegen = 1f;
	public float damage1 = 10f;//type 1
	public float defense1 = 0.5f;// one third reduced damage like in LoL's 50 armour

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (health <= 0) {
			Destroy (gameObject);
		}
		if (health>100){
			health=100;
		}else if (health<100){
			health += Time.deltaTime * healthRegen;
		}
	}

	void OnCollisionStay2D (Collision2D collider){
		if (gameObject.tag == "Blue Triangle" && collider.gameObject.tag == "Red Triangle") {
			health -= collider.gameObject.GetComponent<Status>().damage1*defense1/300;
			Debug.Log (collider.gameObject.GetComponent<Status>().damage1/3);
			Debug.Log (defense1/100);
			Debug.Log (collider.gameObject.GetComponent<Status>().damage1*defense1/300);
			//health -= 5;
		}
		if (gameObject.tag == "Red Triangle" && collider.gameObject.tag == "Blue Triangle") {
			health -= collider.gameObject.GetComponent<Status>().damage1*defense1/300;
			//health -= 5;
		}
	}
}
