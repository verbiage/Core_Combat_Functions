using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	public int playerMaxHealth = 100;
	public int playerCurrentHealth = 100;
	public float healthBarLength;
	// Use this for initialization
	void Start () {
		healthBarLength = Screen.width / 2;
	}
	
	// Update is called once per frame
	void Update () {
		AdjustCurrentHealth (0); 
	}
	void OnGUI() {
		GUI.Box(new Rect(10,10, healthBarLength, 20), playerCurrentHealth + "/" + playerMaxHealth);
		}
	public void AdjustCurrentHealth(int adj) {
		playerCurrentHealth += adj;
		if (playerCurrentHealth < 0)
						playerCurrentHealth = 0;
		if (playerCurrentHealth > playerMaxHealth)
						playerCurrentHealth = playerMaxHealth;
		if (playerMaxHealth < 1)
						playerMaxHealth = 1;
		healthBarLength = (Screen.width / 2) * (playerCurrentHealth / (float)playerMaxHealth);
	}
}
