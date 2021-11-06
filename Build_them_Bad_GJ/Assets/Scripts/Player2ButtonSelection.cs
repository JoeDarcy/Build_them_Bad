using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2ButtonSelection : MonoBehaviour
{
    // Player 2 hull selection bools
    public static bool p2_hull_1_selected = false;
    public static bool p2_hull_2_selected = false;
    public static bool p2_hull_3_selected = false;

    // Player 2 shield selection bools
    public static bool p2_shield_1_selected = false;
    public static bool p2_shield_2_selected = false;
    public static bool p2_shield_3_selected = false;

    // Player 2 weapon selection bools
    public static bool p2_weapon_1_selected = false;
    public static bool p2_weapon_2_selected = false;
    public static bool p2_weapon_3_selected = false;

    // Player 2 engine selection bools
    public static bool p2_engine_1_selected = false;
    public static bool p2_engine_2_selected = false;
    public static bool p2_engine_3_selected = false;

    // Player 2 special weapon selection bools
    public static bool p2_special_1_selected = false;
    public static bool p2_special_2_selected = false;
    public static bool p2_special_3_selected = false;

    // Player 2 hull selection button functions
    public void P2_hull_1_button() {
	    p2_hull_1_selected = true;
	    p2_hull_2_selected = false;
	    p2_hull_3_selected = false;
    }

    public void P2_hull_2_button() {
	    p2_hull_2_selected = true;
	    p2_hull_1_selected = false;
	    p2_hull_3_selected = false;
    }

    public void P2_hull_3_button() {
	    p2_hull_3_selected = true;
	    p2_hull_1_selected = false;
	    p2_hull_2_selected = false;
    }

    // Player 2 shield selection button functions
    public void P2_shield_1_button() {
	    p2_shield_1_selected = true;
	    p2_shield_2_selected = false;
	    p2_shield_3_selected = false;
    }

    public void P2_shield_2_button() {
	    p2_shield_2_selected = true;
	    p2_shield_1_selected = false;
	    p2_shield_3_selected = false;
    }

    public void P2_shield_3_button() {
	    p2_shield_3_selected = true;
	    p2_shield_1_selected = false;
	    p2_shield_2_selected = false;
    }

    // Player 2 weapon selection button functions
    public void P2_weapon_1_button() {
	    p2_weapon_1_selected = true;
	    p2_weapon_2_selected = false;
	    p2_weapon_3_selected = false;
    }

    public void P2_weapon_2_button() {
	    p2_weapon_2_selected = true;
	    p2_weapon_1_selected = false;
	    p2_weapon_3_selected = false;
    }

    public void P2_weapon_3_button() {
	    p2_weapon_3_selected = true;
	    p2_weapon_1_selected = false;
	    p2_weapon_2_selected = false;
    }

    // Player 2 engine selection button functions
    public void P2_engine_1_button() {
	    p2_engine_3_selected = true;
        p2_engine_1_selected = false;
        p2_engine_2_selected = false;
    }

    public void P2_engine_2_button() {
        p2_engine_3_selected = true;
        p2_engine_1_selected = false;
        p2_engine_2_selected = false;
    }

    public void P2_engine_3_button() {
        p2_engine_3_selected = true;
        p2_engine_1_selected = false;
        p2_engine_2_selected = false;
    }

    // Player 2 special weapon selection button functions
    public void P2_special_1_button() {
        p2_special_3_selected = true;
        p2_special_1_selected = false;
        p2_special_2_selected = false;
    }

    public void P2_special_2_button() {
        p2_special_3_selected = true;
        p2_special_1_selected = false;
        p2_special_2_selected = false;
    }

    public void P2_special_3_button() {
        p2_special_3_selected = true;
        p2_special_1_selected = false;
        p2_special_2_selected = false;
    }
}
