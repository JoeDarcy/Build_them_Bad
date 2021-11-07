using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2Health : MonoBehaviour {
	[SerializeField] private GameObject explosion = null;
	private GameObject explosionInstance = null;

	private void Update() {

		Debug.Log("Player shields: " + ShipAttributes.p2_shieldChance);
		Debug.Log("Player 2 health: " + ShipAttributes.p2_health);

		if (ShipAttributes.p2_health <= 0) {
			explosionInstance = Instantiate(explosion, transform.position, Quaternion.identity);
			gameObject.SetActive(false);
		}
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		if (ShipAttributes.p2_hit == true) {
			ShipAttributes.p2_health -= ShipAttributes.p1_weapon;
			Debug.Log("Player shields: " + ShipAttributes.p2_shieldChance);
			Debug.Log("Player 2 health: " + ShipAttributes.p2_health);
		} else {
			Debug.Log("Player 2 evaded hit");
		}
	}
}
