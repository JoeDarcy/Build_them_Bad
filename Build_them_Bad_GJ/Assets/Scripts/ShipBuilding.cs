using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBuilding : MonoBehaviour
{
    // Hull types
    [SerializeField] private GameObject hull_1 = null;
    [SerializeField] private GameObject hull_2 = null;
    [SerializeField] private GameObject hull_3 = null;

    // Shield types
    [SerializeField] private GameObject shield_1 = null;
    [SerializeField] private GameObject shield_2 = null;
    [SerializeField] private GameObject shield_3 = null;

    // Weapon types
    [SerializeField] private GameObject weapon_1 = null;
    [SerializeField] private GameObject weapon_2 = null;
    [SerializeField] private GameObject weapon_3 = null;

    // Engine types
    [SerializeField] private GameObject engine_1 = null;
    [SerializeField] private GameObject engine_2 = null;
    [SerializeField] private GameObject engine_3 = null;

    // Special weapon types
    [SerializeField] private GameObject special_1 = null;
    [SerializeField] private GameObject special_2 = null;
    [SerializeField] private GameObject special_3 = null;

    // Total ship strength
    public static int totalShipStrength = 0;
    private int hullStrength = 0;
    private int shieldStrength = 0;
    private int weaponStrength = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Deactivate all sprites
        hull_1.SetActive(false);
        hull_2.SetActive(false);
        hull_3.SetActive(false);

        shield_1.SetActive(false);
        shield_2.SetActive(false);
        shield_3.SetActive(false);

        weapon_1.SetActive(false);
        weapon_2.SetActive(false);
        weapon_3.SetActive(false);

        engine_1.SetActive(false);
        engine_2.SetActive(false);
        engine_3.SetActive(false);

        special_1.SetActive(false);
        special_2.SetActive(false);
        special_3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Output total ship stregnth
        Debug.Log("Total Ship Strength: " + totalShipStrength);
        Debug.Log("Hull Strength: " + hullStrength);
        Debug.Log("Shield Strength: " + shieldStrength);
        Debug.Log("Weapon Strength: " + weaponStrength);

        // Update total ship strength based on choice of ship components
        totalShipStrength = hullStrength + shieldStrength + weaponStrength;

        // Hull strength
	    if (ButtonSelection.hull_1_selected == true) {
		    hullStrength = 1;
	    }
	    if (ButtonSelection.hull_2_selected == true) {
		    hullStrength = 2;
	    }
	    if (ButtonSelection.hull_3_selected == true) {
		    hullStrength = 3;
	    }

	    // Shield strength
	    if (ButtonSelection.shield_1_selected == true) {
		    shieldStrength = 1;
	    }
	    if (ButtonSelection.shield_2_selected == true) {
		    shieldStrength = 2;
	    }
	    if (ButtonSelection.shield_3_selected == true) {
		    shieldStrength = 3;
	    }

	    // Weapon strength
	    if (ButtonSelection.weapon_1_selected == true) {
		    weaponStrength = 1;
	    }
	    if (ButtonSelection.weapon_2_selected == true) {
		    weaponStrength = 2;
	    }
	    if (ButtonSelection.weapon_3_selected == true) {
		    weaponStrength = 3;
	    }


        // Hull selection
        // Hull 1
        if (ButtonSelection.hull_1_selected == true) {
		    hull_1.SetActive(true);
	    }
	    else {
		    hull_1.SetActive(false);
	    }
	    // Hull 2
        if (ButtonSelection.hull_2_selected == true) {
		    hull_2.SetActive(true);
	    } else {
		    hull_2.SetActive(false);
	    }
        // Hull 3
        if (ButtonSelection.hull_3_selected == true) {
		    hull_3.SetActive(true);
	    } else {
		    hull_3.SetActive(false);
	    }

        // Shield selection
        // Shield 1
        if (ButtonSelection.shield_1_selected == true) {
	        shield_1.SetActive(true);
        } else {
	        shield_1.SetActive(false);
        }
        // Shield 2
        if (ButtonSelection.shield_2_selected == true) {
	        shield_2.SetActive(true);
        } else {
	        shield_2.SetActive(false);
        }
        // Shield 3
        if (ButtonSelection.shield_3_selected == true) {
	        shield_3.SetActive(true);
        } else {
	        shield_3.SetActive(false);
        }

        // Weapon selection
        // Weapon 1
        if (ButtonSelection.weapon_1_selected == true) {
	        weapon_1.SetActive(true);
        } else {
	        weapon_1.SetActive(false);
        }
        // Weapon 2
        if (ButtonSelection.weapon_2_selected == true) {
	        weapon_2.SetActive(true);
        } else {
	        weapon_2.SetActive(false);
        }
        // Weapon 3
        if (ButtonSelection.weapon_3_selected == true) {
	        weapon_3.SetActive(true);
        } else {
	        weapon_3.SetActive(false);
        }
    }
}
