using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelection : MonoBehaviour
{
    // Hull selection bools
    public static bool hull_1_selected = false;
    public static bool hull_2_selected = false;
    public static bool hull_3_selected = false;

    // Hull selection bools
    public static bool shield_1_selected = false;
    public static bool shield_2_selected = false;
    public static bool shield_3_selected = false;

    // Hull selection bools
    public static bool weapon_1_selected = false;
    public static bool weapon_2_selected = false;
    public static bool weapon_3_selected = false;


    // Hull selection button functions
    public void Hull_1_button() {
        hull_1_selected = true;
        hull_2_selected = false;
        hull_3_selected = false;
    }

    public void Hull_2_button() {
        hull_2_selected = true;
        hull_1_selected = false;
        hull_3_selected = false;
    }

    public void Hull_3_button() {
        hull_3_selected = true;
        hull_1_selected = false;
        hull_2_selected = false;
    }

    // Shield selection button functions
    public void shield_1_button() {
	    shield_1_selected = true;
        shield_2_selected = false;
        shield_3_selected = false;
    }

    public void shield_2_button() {
	    shield_2_selected = true;
	    shield_1_selected = false;
	    shield_3_selected = false;
    }

    public void shield_3_button() {
	    shield_3_selected = true;
	    shield_1_selected = false;
	    shield_2_selected = false;
    }

    // Weapon selection button functions
    public void weapon_1_button() {
	    weapon_1_selected = true;
	    weapon_2_selected = false;
	    weapon_3_selected = false;
    }

    public void weapon_2_button() {
	    weapon_2_selected = true;
	    weapon_1_selected = false;
	    weapon_3_selected = false;
    }

    public void weapon_3_button() {
	    weapon_3_selected = true;
	    weapon_1_selected = false;
	    weapon_2_selected = false;
    }
}
