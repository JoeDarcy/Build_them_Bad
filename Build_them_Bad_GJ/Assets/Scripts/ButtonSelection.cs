using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSelection : MonoBehaviour
{
    public static bool hull_1_selected = false;
    public static bool hull_2_selected = false;
    public static bool hull_3_selected = false;
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
}
