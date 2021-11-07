using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class HomingMissile : MonoBehaviour
{
    private Transform target = null;
    [SerializeField] private Rigidbody2D missileRb;
    public float speed = 25.0f;
    public float rotateSpeed = 2.0f;

	private void Awake() {
		target = GameObject.FindGameObjectWithTag("Player_2").transform;
    }
	// Update is called once per frame
	void FixedUpdate()
    {
        missileRb.velocity = transform.forward * speed;
        var rotateAmount = Quaternion.LookRotation(target.position - transform.position);
        missileRb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotateAmount, rotateSpeed));  
    }
}
