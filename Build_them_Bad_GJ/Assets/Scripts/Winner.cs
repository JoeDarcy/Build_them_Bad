using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    [SerializeField] private GameObject p1_wins = null;
    [SerializeField] private GameObject p2_wins = null;

    // Update is called once per frame
    void Update()
    {
	    if (ShipAttributes.p1_health > ShipAttributes.p2_health)
	    {
		    p1_wins.SetActive(true);
            p2_wins.SetActive(false);
        }
	    else
	    {
		    p1_wins.SetActive(false);
		    p2_wins.SetActive(true);
        }
    }
}
