using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBarScaling : MonoBehaviour
{
	[SerializeField] private GameObject p1_progressBar = null;
	[SerializeField] private GameObject p2_progressBar = null;
	[SerializeField] private GameObject p1_overPoweredBar = null;
	[SerializeField] private GameObject p2_overPoweredBar = null;
	private Vector3 p1_progressBarScale;
    private float p1_scaleValue = 0.0f;
    private Vector3 p2_progressBarScale;
    private float p2_scaleValue = 0.0f;

	// Update is called once per frame
	void Update()
    {
        //Update player 1 progress bar scale
	    p1_progressBarScale = new Vector3(transform.localScale.x * p1_scaleValue, transform.localScale.y, transform.localScale.z);
	    p1_progressBar.transform.localScale = p1_progressBarScale;

	    //Update player 2 progress bar scale
	    p2_progressBarScale = new Vector3(transform.localScale.x * p2_scaleValue, transform.localScale.y, transform.localScale.z);
	    p2_progressBar.transform.localScale = p2_progressBarScale;

		// Change player 1 scale value based on total ship strength
		if (ShipBuilding.p1_totalShipStrength == 0) {
		    p1_scaleValue = 0.0f;
	    } else if (ShipBuilding.p1_totalShipStrength == 1) {
			p1_scaleValue = 0.1f;
	    } else if (ShipBuilding.p1_totalShipStrength == 2) {
			p1_scaleValue = 0.2f;
        } else if (ShipBuilding.p1_totalShipStrength == 3) {
			p1_scaleValue = 0.3f;
        } else if (ShipBuilding.p1_totalShipStrength == 4) {
			p1_scaleValue = 0.4f;
        } else if (ShipBuilding.p1_totalShipStrength == 5) {
			p1_scaleValue = 0.5f;
        } else if (ShipBuilding.p1_totalShipStrength == 6) {
			p1_scaleValue = 0.6f;
        } else if (ShipBuilding.p1_totalShipStrength == 7) {
			p1_scaleValue = 0.7f;
        } else if (ShipBuilding.p1_totalShipStrength == 8) {
			p1_scaleValue = 0.8f;
        } else if (ShipBuilding.p1_totalShipStrength == 9) {
			p1_scaleValue = 0.9f;
        } else if (ShipBuilding.p1_totalShipStrength >= 10) {
			p1_scaleValue = 1.0f;
			p1_overPoweredBar.SetActive(true);
		} 

		if (ShipBuilding.p1_totalShipStrength < 11) {
			p1_overPoweredBar.SetActive(false);
		} else {
			p1_overPoweredBar.SetActive(true);
		}

		// Change player 2 scale value based on total ship strength
		if (ShipBuilding.p2_totalShipStrength == 0) {
			p2_scaleValue = 0.0f;
		} else if (ShipBuilding.p2_totalShipStrength == 1) {
			p2_scaleValue = 0.1f;
		} else if (ShipBuilding.p2_totalShipStrength == 2) {
			p2_scaleValue = 0.2f;
		} else if (ShipBuilding.p2_totalShipStrength == 3) {
			p2_scaleValue = 0.3f;
		} else if (ShipBuilding.p2_totalShipStrength == 4) {
			p2_scaleValue = 0.4f;
		} else if (ShipBuilding.p2_totalShipStrength == 5) {
			p2_scaleValue = 0.5f;
		} else if (ShipBuilding.p2_totalShipStrength == 6) {
			p2_scaleValue = 0.6f;
		} else if (ShipBuilding.p2_totalShipStrength == 7) {
			p2_scaleValue = 0.7f;
		} else if (ShipBuilding.p2_totalShipStrength == 8) {
			p2_scaleValue = 0.8f;
		} else if (ShipBuilding.p2_totalShipStrength == 9) {
			p2_scaleValue = 0.9f;
		} else if (ShipBuilding.p2_totalShipStrength >= 10) {
			p2_scaleValue = 1.0f;
		}
		
		if (ShipBuilding.p2_totalShipStrength < 11) {
			p2_overPoweredBar.SetActive(false);
		}
		else
		{
			p2_overPoweredBar.SetActive(true);
		}
	}
}
