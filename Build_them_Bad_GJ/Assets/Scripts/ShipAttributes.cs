using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipAttributes : MonoBehaviour
{
	// Health
	public static int p1_health = 0;
	public static int p2_health = 0;
	// Shields
	public static int p1_shieldChance = 0;
	public static int p2_shieldChance = 0;
	private int p1_diceRoll = 0;
	private int p2_diceRoll = 0;
	public static bool p1_hit = false;
	public static bool p2_hit = false;

	// Start is called before the first frame update
	void Start()
    {	// Set player 1 health
	    if (ShipBuilding.p1_hullStrength == 1) {
			p1_health = 12;
	    } else if (ShipBuilding.p1_hullStrength == 2) {
			p1_health = 14;
	    } else if (ShipBuilding.p1_hullStrength == 3) {
			p1_health = 16;
	    }

	    // Set player 2 health
	    if (ShipBuilding.p2_hullStrength == 1) {
			p2_health = 12;
	    } else if (ShipBuilding.p2_hullStrength == 2) {
			p2_health = 14;
	    } else if (ShipBuilding.p2_hullStrength == 3) {
			p2_health = 16;
	    }

	    // Set player 1 shield
	    if (ShipBuilding.p1_shieldStrength == 1) {
			p1_shieldChance = 2;
	    } else if (ShipBuilding.p1_shieldStrength == 2) {
			p1_shieldChance = 3;
	    } else if (ShipBuilding.p1_shieldStrength == 3) {
			p1_shieldChance = 5;
	    }

	    // Set player 2 shield
	    if (ShipBuilding.p2_shieldStrength == 1) {
			p2_shieldChance = 2;
	    } else if (ShipBuilding.p2_shieldStrength == 2) {
			p2_shieldChance = 3;
	    } else if (ShipBuilding.p2_shieldStrength == 3) {
			p2_shieldChance = 5;
	    }



	}


	private void Update() {
		// Shield hit chance
		if (p1_shieldChance == 1)
		{
			p1_diceRoll = Random.Range(1, 10);

			if (p1_diceRoll > 2) {
				p1_hit = true;
			}
			else {
				p1_hit = false;
			}
		}
	}
}
