using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_Movement : MonoBehaviour
{
	[SerializeField] private float pos_X_ShipSpeed = 0.0f;
	[SerializeField] private float neg_X_ShipSpeed = 0.0f;
	[SerializeField] private float pos_Y_ShipSpeed = 0.0f;
	[SerializeField] private float neg_Y_ShipSpeed = 0.0f;
	[SerializeField] private float maxSpeed = 0.0f;
	public static float p2_accelerationSpeed = 0.0f;
	public static float p2_decelerationSpeed = 0.0f;

	private bool rightPressed = false;
	private bool leftPressed = false;
	private bool upPressed = false;
	private bool downPressed = false;

	// Start is called before the first frame update
	void Start() {
		pos_X_ShipSpeed = 0.0f;
	}

	// Update is called once per frame
	void Update() {

		// Update acceleration and deceleration based of ship attributes
		p2_accelerationSpeed = ShipAttributes.p2_engineAcceleration;
		p2_decelerationSpeed = ShipAttributes.p2_engineDeceleration;

		// Right pressed
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rightPressed = true;
		}
		// Right released
		if (Input.GetKeyUp(KeyCode.RightArrow)) {
			rightPressed = false;
		}

		// Left pressed
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			leftPressed = true;
		}
		// Left released
		if (Input.GetKeyUp(KeyCode.LeftArrow)) {
			leftPressed = false;
		}

		// Up pressed
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			upPressed = true;
		}
		// Up released
		if (Input.GetKeyUp(KeyCode.UpArrow)) {
			upPressed = false;
		}

		// Down pressed
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			downPressed = true;
		}
		// Down released
		if (Input.GetKeyUp(KeyCode.DownArrow)) {
			downPressed = false;
		}

		// Right acceleration
		if (rightPressed == true) {
			if (pos_X_ShipSpeed <= maxSpeed) {
				pos_X_ShipSpeed += p2_accelerationSpeed;
			}
		}
		if (rightPressed == false) {
			if (pos_X_ShipSpeed > 0) {
				pos_X_ShipSpeed -= p2_decelerationSpeed;
			} else if (pos_X_ShipSpeed < 0) {
				pos_X_ShipSpeed = 0;
			}
		}

		// Left acceleration
		if (leftPressed == true) {
			if (neg_X_ShipSpeed >= -maxSpeed) {
				neg_X_ShipSpeed -= p2_accelerationSpeed;
			}
		}
		if (leftPressed == false) {
			if (neg_X_ShipSpeed < 0) {
				neg_X_ShipSpeed += p2_decelerationSpeed;
			} else if (neg_X_ShipSpeed > 0) {
				neg_X_ShipSpeed = 0;
			}
		}

		// Up acceleration
		if (upPressed == true) {
			if (pos_Y_ShipSpeed <= maxSpeed) {
				pos_Y_ShipSpeed += p2_accelerationSpeed;
			}
		}
		if (upPressed == false) {
			if (pos_Y_ShipSpeed > 0) {
				pos_Y_ShipSpeed -= p2_decelerationSpeed;
			} else if (pos_Y_ShipSpeed < 0) {
				pos_Y_ShipSpeed = 0;
			}
		}

		// Down acceleration
		if (downPressed == true) {
			if (neg_Y_ShipSpeed >= -maxSpeed) {
				neg_Y_ShipSpeed -= p2_accelerationSpeed;
			}
		}
		if (downPressed == false) {
			if (neg_Y_ShipSpeed < 0) {
				neg_Y_ShipSpeed += p2_decelerationSpeed;
			} else if (neg_Y_ShipSpeed > 0) {
				neg_Y_ShipSpeed = 0;
			}
		}

		// Movement
		transform.position = new Vector3(transform.position.x + ((pos_X_ShipSpeed / 10) + (neg_X_ShipSpeed / 10)), transform.position.y + ((pos_Y_ShipSpeed / 10) + (neg_Y_ShipSpeed / 10)), transform.position.z);
	}
}
