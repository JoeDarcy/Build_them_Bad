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
	// Weapons
	public static int p1_weapon = 0;
	public static int p2_weapon = 0;
	// Engines
	public static float p1_engineAcceleration = 0.0f;
	public static float p1_engineDeceleration = 0.0f;
	public static float p2_engineAcceleration = 0.0f;
	public static float p2_engineDeceleration = 0.0f;
	//Special Weapons
	public static int p1_specialWeapon = 0;
	public static int p2_specialWeapon = 0;

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

	    // Set player 1 weapon
	    if (ShipBuilding.p1_weaponStrength == 1) {
			p1_weapon = 1;
	    } else if (ShipBuilding.p1_weaponStrength == 2) {
			p1_weapon = 2;
	    } else if (ShipBuilding.p1_weaponStrength == 3) {
			p1_weapon = 3;
	    }

		// Set player 2 weapon
		if (ShipBuilding.p2_weaponStrength == 1) {
			p2_weapon = 1;
	    } else if (ShipBuilding.p2_weaponStrength == 2) {
			p2_weapon = 2;
	    } else if (ShipBuilding.p2_weaponStrength == 3) {
			p2_weapon = 3;
	    }

		// Set player 1 engine
		if (ShipBuilding.p1_engineStrength == 1) {
			p1_engineAcceleration = 0.0001f;
			p1_engineDeceleration = 0.0001f;
		} else if (ShipBuilding.p1_engineStrength == 2) {
			p1_engineAcceleration = 0.0005f;
			p1_engineDeceleration = 0.0003f;
		} else if (ShipBuilding.p1_engineStrength == 3) {
			p1_engineAcceleration = 0.001f;
			p1_engineDeceleration = 0.0006f;
		}

		// Set player 2 engine
		if (ShipBuilding.p2_engineStrength == 1) {
			p2_engineAcceleration = 0.0001f;
			p2_engineDeceleration = 0.0001f;
		} else if (ShipBuilding.p2_engineStrength == 2) {
			p2_engineAcceleration = 0.0005f;
			p2_engineDeceleration = 0.0003f;
		} else if (ShipBuilding.p2_engineStrength == 3) {
			p2_engineAcceleration = 0.001f;
			p2_engineDeceleration = 0.0006f;
		}

		// Set player 1 special weapon
		if (ShipBuilding.p1_specialWeaponStrength == 1) {
			p1_specialWeapon = 1;
		} else if (ShipBuilding.p1_specialWeaponStrength == 2) {
			p1_specialWeapon = 2;
		} else if (ShipBuilding.p1_specialWeaponStrength == 3) {
			p1_specialWeapon = 3;
		}

		// Set player 2 special weapon
		if (ShipBuilding.p2_specialWeaponStrength == 1) {
			p2_specialWeapon = 1;
		} else if (ShipBuilding.p2_specialWeaponStrength == 2) {
			p2_specialWeapon = 2;
		} else if (ShipBuilding.p2_specialWeaponStrength == 3) {
			p2_specialWeapon = 3;
		}
	}


	private void Update() {
		// Shield hit chance
		// Player 1 Hull 1
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
		// Player 1 Hull 2
		if (p1_shieldChance == 2) {
			p1_diceRoll = Random.Range(1, 10);

			if (p1_diceRoll > 3) {
				p1_hit = true;
			} else {
				p1_hit = false;
			}
		}
		// Player 1 Hull 3
		if (p1_shieldChance == 3) {
			p1_diceRoll = Random.Range(1, 10);

			if (p1_diceRoll > 5) {
				p1_hit = true;
			} else {
				p1_hit = false;
			}
		}

		// Player 2 Hull 1
		if (p2_shieldChance == 1) {
			p2_diceRoll = Random.Range(1, 10);

			if (p2_diceRoll > 2) {
				p2_hit = true;
			} else {
				p2_hit = false;
			}
		}
		// Player 2 Hull 2
		if (p2_shieldChance == 2) {
			p2_diceRoll = Random.Range(1, 10);

			if (p2_diceRoll > 3) {
				p2_hit = true;
			} else {
				p2_hit = false;
			}
		}
		// Player 2 Hull 3
		if (p2_shieldChance == 3) {
			p2_diceRoll = Random.Range(1, 10);

			if (p2_diceRoll > 5) {
				p2_hit = true;
			} else {
				p2_hit = false;
			}
		}
	}
}
