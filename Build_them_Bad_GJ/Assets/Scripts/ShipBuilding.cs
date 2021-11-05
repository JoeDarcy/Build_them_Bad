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
        // Hull selection
        // Hull 1
	    if (ButtonSelection.hull_1_selected == true)
	    {
		    hull_1.SetActive(true);
	    }
	    else
	    {
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
    }
}
