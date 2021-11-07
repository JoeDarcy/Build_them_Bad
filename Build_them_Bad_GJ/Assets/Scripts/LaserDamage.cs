using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserDamage : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision) {

		if (collision.gameObject.tag == "Player_1")
		{
			//Debug.Log("Player 1 hit");
			ShipAttributes.p1_health -= 1;
		}

		if (collision.gameObject.tag == "Player_2") {
			//Debug.Log("Player 2 hit");
			ShipAttributes.p2_health -= 1;
		}
	}
}
