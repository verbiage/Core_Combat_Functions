using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyUp (KeyCode.F)) {
			Attack();}	
	}
	private void Attack() {
		float distance = Vector3.Distance (target.transform.position, transform.position);
		Vector3 dir = (target.transform.position - transform.position).normalized;
		float direction = Vector3.Dot (dir, transform.forward);
		Debug.Log (direction);
		if (distance < 2.5f) {
						if (direction > 0) {
								EnemyHealth eh = (EnemyHealth)target.GetComponent ("EnemyHealth");
								eh.AdjustCurrentHealth (-10);
						}
				}
	}
}
