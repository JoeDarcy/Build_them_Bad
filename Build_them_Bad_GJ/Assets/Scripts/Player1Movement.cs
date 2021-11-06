using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Movement : MonoBehaviour
{
	[SerializeField] private float pos_X_ShipSpeed = 0.0f;
	[SerializeField] private float neg_X_ShipSpeed = 0.0f;
	[SerializeField] private float pos_Y_ShipSpeed = 0.0f;
	[SerializeField] private float neg_Y_ShipSpeed = 0.0f;
	[SerializeField] private float maxSpeed = 0.0f;
	[SerializeField] private float accelerationSpeed = 0.0f;
	[SerializeField] private float decelerationSpeed = 0.0f;

	private bool rightPressed = false;
	private bool leftPressed = false;
	private bool upPressed = false;
	private bool downPressed = false;

	// Start is called before the first frame update
	void Start()
    {
	    pos_X_ShipSpeed = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

		// Right pressed
	    if (Input.GetKeyDown("d"))
	    {
			rightPressed = true;
	    }
		// Right released
	    if (Input.GetKeyUp("d")) {
			rightPressed = false;
	    }

	    // Left pressed
	    if (Input.GetKeyDown("a")) {
		    leftPressed = true;
	    }
	    // Left released
	    if (Input.GetKeyUp("a")) {
		    leftPressed = false;
	    }

	    // Up pressed
	    if (Input.GetKeyDown("w")) {
		    upPressed = true;
	    }
	    // Up released
	    if (Input.GetKeyUp("w")) {
		    upPressed = false;
	    }

	    // Down pressed
	    if (Input.GetKeyDown("s")) {
		    downPressed = true;
	    }
	    // Down released
	    if (Input.GetKeyUp("s")) {
		    downPressed = false;
	    }

		// Right acceleration
		if (rightPressed == true)
	    {
		    if (pos_X_ShipSpeed <= maxSpeed) {
			    pos_X_ShipSpeed += accelerationSpeed;
		    }
		}
	    if (rightPressed == false) {
			if (pos_X_ShipSpeed > 0) {
				pos_X_ShipSpeed -= decelerationSpeed;
			} else if (pos_X_ShipSpeed < 0)
			{
				pos_X_ShipSpeed = 0;
			}
		}

		// Left acceleration
		if (leftPressed == true)
		{
			if (neg_X_ShipSpeed >= -maxSpeed) {
				neg_X_ShipSpeed -= accelerationSpeed;
			}
		}
		if (leftPressed == false) {
			if (neg_X_ShipSpeed < 0) {
				neg_X_ShipSpeed += decelerationSpeed;
			} else if (neg_X_ShipSpeed > 0) {
				neg_X_ShipSpeed = 0;
			}
		}

		// Up acceleration
		if (upPressed == true) {
			if (pos_Y_ShipSpeed <= maxSpeed) {
				pos_Y_ShipSpeed += accelerationSpeed;
			}
		}
		if (upPressed == false) {
			if (pos_Y_ShipSpeed > 0) {
				pos_Y_ShipSpeed -= decelerationSpeed;
			} else if (pos_Y_ShipSpeed < 0) {
				pos_Y_ShipSpeed = 0;
			}
		}

		// Down acceleration
		if (downPressed == true) {
			if (neg_Y_ShipSpeed >= -maxSpeed) {
				neg_Y_ShipSpeed -= accelerationSpeed;
			}
		}
		if (downPressed == false) {
			if (neg_Y_ShipSpeed < 0) {
				neg_Y_ShipSpeed += decelerationSpeed;
			} else if (neg_Y_ShipSpeed > 0) {
				neg_Y_ShipSpeed = 0;
			}
		}

		// Movement
		transform.position = new Vector3(transform.position.x + ((pos_X_ShipSpeed / 10) + (neg_X_ShipSpeed / 10)), transform.position.y + ((pos_Y_ShipSpeed / 10) + (neg_Y_ShipSpeed / 10)), transform.position.z);
    }
}
