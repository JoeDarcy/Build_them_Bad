using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1ButtonSelection : MonoBehaviour
{
    // Player 1 hull selection bools
    public static bool p1_hull_1_selected = false;
    public static bool p1_hull_2_selected = false;
    public static bool p1_hull_3_selected = false;

    // Player 1 shield selection bools
    public static bool p1_shield_1_selected = false;
    public static bool p1_shield_2_selected = false;
    public static bool p1_shield_3_selected = false;

    // Player 1 weapon selection bools
    public static bool p1_weapon_1_selected = false;
    public static bool p1_weapon_2_selected = false;
    public static bool p1_weapon_3_selected = false;

    // Player 1 engine selection bools
    public static bool p1_engine_1_selected = false;
    public static bool p1_engine_2_selected = false;
    public static bool p1_engine_3_selected = false;

    // Player 1 special weapon selection bools
    public static bool p1_special_1_selected = false;
    public static bool p1_special_2_selected = false;
    public static bool p1_special_3_selected = false;

    // Player 1 hull selection button functions
    public void P1_hull_1_button() {
	    p1_hull_1_selected = true;
	    p1_hull_2_selected = false;
	    p1_hull_3_selected = false;
    }

    public void P1_hull_2_button() {
	    p1_hull_2_selected = true;
	    p1_hull_1_selected = false;
	    p1_hull_3_selected = false;
    }

    public void P1_hull_3_button() {
	    p1_hull_3_selected = true;
	    p1_hull_1_selected = false;
	    p1_hull_2_selected = false;
    }

    // Player 1 shield selection button functions
    public void P1_shield_1_button() {
	    p1_shield_1_selected = true;
	    p1_shield_2_selected = false;
	    p1_shield_3_selected = false;
    }

    public void P1_shield_2_button() {
	    p1_shield_2_selected = true;
	    p1_shield_1_selected = false;
	    p1_shield_3_selected = false;
    }

    public void P1_shield_3_button() {
	    p1_shield_3_selected = true;
	    p1_shield_1_selected = false;
	    p1_shield_2_selected = false;
    }

    // Player 1 weapon selection button functions
    public void P1_weapon_1_button() {
	    p1_weapon_1_selected = true;
	    p1_weapon_2_selected = false;
	    p1_weapon_3_selected = false;
    }

    public void P1_weapon_2_button() {
	    p1_weapon_2_selected = true;
	    p1_weapon_1_selected = false;
	    p1_weapon_3_selected = false;
    }

    public void P1_weapon_3_button() {
	    p1_weapon_3_selected = true;
	    p1_weapon_1_selected = false;
	    p1_weapon_2_selected = false;
    }

    // Player 1 engine selection button functions
    public void P1_engine_1_button() {
	    p1_engine_3_selected = true;
        p1_engine_1_selected = false;
        p1_engine_2_selected = false;
    }

    public void P1_engine_2_button() {
        p1_engine_3_selected = true;
        p1_engine_1_selected = false;
        p1_engine_2_selected = false;
    }

    public void P1_engine_3_button() {
        p1_engine_3_selected = true;
        p1_engine_1_selected = false;
        p1_engine_2_selected = false;
    }

    // Player 1 special weapon selection button functions
    public void P1_special_1_button() {
        p1_special_3_selected = true;
        p1_special_1_selected = false;
        p1_special_2_selected = false;
    }

    public void P1_special_2_button() {
        p1_special_3_selected = true;
        p1_special_1_selected = false;
        p1_special_2_selected = false;
    }

    public void P1_special_3_button() {
        p1_special_3_selected = true;
        p1_special_1_selected = false;
        p1_special_2_selected = false;
    }
}
