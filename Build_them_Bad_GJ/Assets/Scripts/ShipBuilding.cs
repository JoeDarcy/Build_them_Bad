using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBuilding : MonoBehaviour
{
    // Player 1 hull types
    [SerializeField] private GameObject p1_hull_1 = null;
    [SerializeField] private GameObject p1_hull_2 = null;
    [SerializeField] private GameObject p1_hull_3 = null;

    // Player 1 shield types
    [SerializeField] private GameObject p1_shield_1 = null;
    [SerializeField] private GameObject p1_shield_2 = null;
    [SerializeField] private GameObject p1_shield_3 = null;

    // Player 1 weapon types
    [SerializeField] private GameObject p1_weapon_1 = null;
    [SerializeField] private GameObject p1_weapon_2 = null;
    [SerializeField] private GameObject p1_weapon_3 = null;

    // Player 1 engine types
    [SerializeField] private GameObject p1_engine_1 = null;
    [SerializeField] private GameObject p1_engine_2 = null;
    [SerializeField] private GameObject p1_engine_3 = null;

    // Player 1 special weapon types
    [SerializeField] private GameObject p1_special_1 = null;
    [SerializeField] private GameObject p1_special_2 = null;
    [SerializeField] private GameObject p1_special_3 = null;


    // Player 2 hull types
    [SerializeField] private GameObject p2_hull_1 = null;
    [SerializeField] private GameObject p2_hull_2 = null;
    [SerializeField] private GameObject p2_hull_3 = null;

    // Player 2 shield types
    [SerializeField] private GameObject p2_shield_1 = null;
    [SerializeField] private GameObject p2_shield_2 = null;
    [SerializeField] private GameObject p2_shield_3 = null;

    // Player 2 weapon types
    [SerializeField] private GameObject p2_weapon_1 = null;
    [SerializeField] private GameObject p2_weapon_2 = null;
    [SerializeField] private GameObject p2_weapon_3 = null;

    // Player 2 engine types
    [SerializeField] private GameObject p2_engine_1 = null;
    [SerializeField] private GameObject p2_engine_2 = null;
    [SerializeField] private GameObject p2_engine_3 = null;

    // Player 2 special weapon types
    [SerializeField] private GameObject p2_special_1 = null;
    [SerializeField] private GameObject p2_special_2 = null;
    [SerializeField] private GameObject p2_special_3 = null;


    // Total ship strength
    // Player 1
    public static int p1_totalShipStrength = 0;
    public static int p1_hullStrength = 0;
    public static int p1_shieldStrength = 0;
    public static int p1_weaponStrength = 0;
    // Player 2
    public static int p2_totalShipStrength = 0;
    public static int p2_hullStrength = 0;
    public static int p2_shieldStrength = 0;
    public static int p2_weaponStrength = 0;

    // Start is called before the first frame update
    void Start()
    {
        //=================================== Deactivate all Sprites ===================================
        // Player 1 sprites
        p1_hull_1.SetActive(false);
        p1_hull_2.SetActive(false);
        p1_hull_3.SetActive(false);

        p1_shield_1.SetActive(false);
        p1_shield_2.SetActive(false);
        p1_shield_3.SetActive(false);

        p1_weapon_1.SetActive(false);
        p1_weapon_2.SetActive(false);
        p1_weapon_3.SetActive(false);

        p1_engine_1.SetActive(false);
        p1_engine_2.SetActive(false);
        p1_engine_3.SetActive(false);

        p1_special_1.SetActive(false);
        p1_special_2.SetActive(false);
        p1_special_3.SetActive(false);

        // Player 2 sprites
        p2_hull_1.SetActive(false);
        p2_hull_2.SetActive(false);
        p2_hull_3.SetActive(false);

        p2_shield_1.SetActive(false);
        p2_shield_2.SetActive(false);
        p2_shield_3.SetActive(false);

        p2_weapon_1.SetActive(false);
        p2_weapon_2.SetActive(false);
        p2_weapon_3.SetActive(false);

        p2_engine_1.SetActive(false);
        p2_engine_2.SetActive(false);
        p2_engine_3.SetActive(false);

        p2_special_1.SetActive(false);
        p2_special_2.SetActive(false);
        p2_special_3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
	    //=================================== Player 1 Strength Count ===================================
        // Player 1 hull strength
        if (Player1ButtonSelection.p1_hull_1_selected == true) {
	        p1_hullStrength = 1;
	    }
	    if (Player1ButtonSelection.p1_hull_2_selected == true) {
		    p1_hullStrength = 2;
	    }
	    if (Player1ButtonSelection.p1_hull_3_selected == true) {
		    p1_hullStrength = 3;
	    }

	    // Player 1 shield strength
        if (Player1ButtonSelection.p1_shield_1_selected == true) {
	        p1_shieldStrength = 1;
	    }
	    if (Player1ButtonSelection.p1_shield_2_selected == true) {
		    p1_shieldStrength = 2;
	    }
	    if (Player1ButtonSelection.p1_shield_3_selected == true) {
		    p1_shieldStrength = 3;
	    }

	    // Player 1 weapon strength
        if (Player1ButtonSelection.p1_weapon_1_selected == true) {
	        p1_weaponStrength = 1;
	    }
	    if (Player1ButtonSelection.p1_weapon_2_selected == true) {
		    p1_weaponStrength = 2;
	    }
	    if (Player1ButtonSelection.p1_weapon_3_selected == true) {
		    p1_weaponStrength = 3;
	    }

	    //=================================== Player 2 Strength Count ===================================
        // Player 2 hull strength
        if (Player2ButtonSelection.p2_hull_1_selected == true) {
	        p2_hullStrength = 1;
        }
        if (Player2ButtonSelection.p2_hull_2_selected == true) {
	        p2_hullStrength = 2;
        }
        if (Player2ButtonSelection.p2_hull_3_selected == true) {
	        p2_hullStrength = 3;
        }

        // Player 2 shield strength
        if (Player2ButtonSelection.p2_shield_1_selected == true) {
	        p2_shieldStrength = 1;
        }
        if (Player2ButtonSelection.p2_shield_2_selected == true) {
	        p2_shieldStrength = 2;
        }
        if (Player2ButtonSelection.p2_shield_3_selected == true) {
	        p2_shieldStrength = 3;
        }

        // Player 2 weapon strength
        if (Player2ButtonSelection.p2_weapon_1_selected == true) {
	        p2_weaponStrength = 1;
        }
        if (Player2ButtonSelection.p2_weapon_2_selected == true) {
	        p2_weaponStrength = 2;
        }
        if (Player2ButtonSelection.p2_weapon_3_selected == true) {
	        p2_weaponStrength = 3;
        }

        //=================================== Strength Calculation ===================================
        // Update total ship strength based on choice of ship components
        // Player 1
        p1_totalShipStrength = p1_hullStrength + p1_shieldStrength + p1_weaponStrength;
        // Player 2
        p2_totalShipStrength = p2_hullStrength + p2_shieldStrength + p2_weaponStrength;

        //=================================== Strength Output ===================================
        // Output total ship strength
        // Player 1
        Debug.Log("Player 1 total Ship Strength: " + p1_totalShipStrength);
        Debug.Log("Player 1 hull Strength: " + p1_hullStrength);
        Debug.Log("Player 1 shield Strength: " + p1_shieldStrength);
        Debug.Log("Player 1 weapon Strength: " + p1_weaponStrength);
        // Player 2
        Debug.Log("Player 2 total Ship Strength: " + p2_totalShipStrength);
        Debug.Log("Player 2 hull Strength: " + p2_hullStrength);
        Debug.Log("Player 2 shield Strength: " + p2_shieldStrength);
        Debug.Log("Player 2 weapon Strength: " + p2_weaponStrength);


        //=================================== Player 1 Component Selection ===================================
        // Player 1 hull selection
        // Hull 1
        if (Player1ButtonSelection.p1_hull_1_selected == true) {
	        p1_hull_1.SetActive(true);
	    }
	    else {
	        p1_hull_1.SetActive(false);
	    }
	    // Hull 2
        if (Player1ButtonSelection.p1_hull_2_selected == true) {
	        p1_hull_2.SetActive(true);
	    } else {
	        p1_hull_2.SetActive(false);
	    }
        // Hull 3
        if (Player1ButtonSelection.p1_hull_3_selected == true) {
	        p1_hull_3.SetActive(true);
	    } else {
	        p1_hull_3.SetActive(false);
	    }

        // Player 1 shield selection
        // Shield 1
        if (Player1ButtonSelection.p1_shield_1_selected == true) {
	        p1_shield_1.SetActive(true);
        } else {
	        p1_shield_1.SetActive(false);
        }
        // Shield 2
        if (Player1ButtonSelection.p1_shield_2_selected == true) {
	        p1_shield_2.SetActive(true);
        } else {
	        p1_shield_2.SetActive(false);
        }
        // Shield 3
        if (Player1ButtonSelection.p1_shield_3_selected == true) {
	        p1_shield_3.SetActive(true);
        } else {
	        p1_shield_3.SetActive(false);
        }

        // Weapon selection
        // Weapon 1
        if (Player1ButtonSelection.p1_weapon_1_selected == true) {
	        p1_weapon_1.SetActive(true);
        } else {
	        p1_weapon_1.SetActive(false);
        }
        // Weapon 2
        if (Player1ButtonSelection.p1_weapon_2_selected == true) {
	        p1_weapon_2.SetActive(true);
        } else {
	        p1_weapon_2.SetActive(false);
        }
        // Weapon 3
        if (Player1ButtonSelection.p1_weapon_3_selected == true) {
	        p1_weapon_3.SetActive(true);
        } else {
	        p1_weapon_3.SetActive(false);
        }


        //=================================== Player 2 Component Selection ===================================
        // Player 2 hull selection
        // Hull 1
        if (Player2ButtonSelection.p2_hull_1_selected == true) {
	        p2_hull_1.SetActive(true);
        } else {
	        p2_hull_1.SetActive(false);
        }
        // Hull 2
        if (Player2ButtonSelection.p2_hull_2_selected == true) {
	        p2_hull_2.SetActive(true);
        } else {
	        p2_hull_2.SetActive(false);
        }
        // Hull 3
        if (Player2ButtonSelection.p2_hull_3_selected == true) {
	        p2_hull_3.SetActive(true);
        } else {
	        p2_hull_3.SetActive(false);
        }

        // Player 2 shield selection
        // Shield 1
        if (Player2ButtonSelection.p2_shield_1_selected == true) {
	        p2_shield_1.SetActive(true);
        } else {
	        p2_shield_1.SetActive(false);
        }
        // Shield 2
        if (Player2ButtonSelection.p2_shield_2_selected == true) {
	        p2_shield_2.SetActive(true);
        } else {
	        p2_shield_2.SetActive(false);
        }
        // Shield 3
        if (Player2ButtonSelection.p2_shield_3_selected == true) {
	        p2_shield_3.SetActive(true);
        } else {
	        p2_shield_3.SetActive(false);
        }

        // Player 2 weapon selection
        // Weapon 1
        if (Player2ButtonSelection.p2_weapon_1_selected == true) {
	        p2_weapon_1.SetActive(true);
        } else {
	        p2_weapon_1.SetActive(false);
        }
        // Weapon 2
        if (Player2ButtonSelection.p2_weapon_2_selected == true) {
	        p2_weapon_2.SetActive(true);
        } else {
	        p2_weapon_2.SetActive(false);
        }
        // Weapon 3
        if (Player2ButtonSelection.p2_weapon_3_selected == true) {
	        p2_weapon_3.SetActive(true);
        } else {
	        p2_weapon_3.SetActive(false);
        }
    }
}
