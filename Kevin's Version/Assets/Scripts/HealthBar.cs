using UnityEngine;
using System.Collections;

public class HealthBar : MonoBehaviour {

	private SpriteRenderer RB2;
	private Vector3 healthScale;

	// Use this for initialization
	void Start () {;
		RB2 = gameObject.GetComponent<SpriteRenderer> ();
		healthScale = RB2.transform.localScale;
	}
	
	// Update is called once per frame
	void Update () {
		//if (health <= 0) {
		//	Destroy (transform.parent.parent.gameObject);
		//}
		//transform.parent.parent.gameObject.GetComponent<Status> ().health += Time.deltaTime * healthRegen;
		healthUpdate ();
	}

	void healthUpdate(){
		RB2.transform.localScale = new Vector3 (healthScale.x * transform.parent.parent.gameObject.GetComponent<Status> ().health * 0.01f, 1, 1);
	}
}