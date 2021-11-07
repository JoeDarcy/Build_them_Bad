using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Health : MonoBehaviour {
	[SerializeField] private GameObject explosion = null;
	private GameObject explosionInstance = null;

	private void Update() {

		//Debug.Log("Player shields: " + ShipAttributes.p1_shieldChance);
		Debug.Log("Player 1 health: " + ShipAttributes.p1_health);

		if (ShipAttributes.p1_health <= 0) {
			explosionInstance = Instantiate(explosion, transform.position, Quaternion.identity);
			gameObject.SetActive(false);
		}
	}
	private void OnTriggerEnter2D(Collider2D collision) {
		if (ShipAttributes.p1_hit == true) {
			ShipAttributes.p1_health -= ShipAttributes.p2_weapon;
			//Debug.Log("Player shields: " + ShipAttributes.p1_shieldChance);
			Debug.Log("Player 1 health: " + ShipAttributes.p1_health);
		} else {
			Debug.Log("Player 1 evaded hit");
		}
	}
}
