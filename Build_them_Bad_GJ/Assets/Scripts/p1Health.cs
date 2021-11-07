using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Health : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision) {
		if (ShipAttributes.p1_hit == true)
		{
			ShipAttributes.p1_health -= ShipAttributes.p2_weapon;
			Debug.Log("Player shields: " + ShipAttributes.p1_shieldChance);
			Debug.Log("Player 1 health: " + ShipAttributes.p1_health);
		} else {
			Debug.Log("Player 2 evaded hit");
		}
		
	}
}
