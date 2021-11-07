using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   [RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    public Transform target;

	public float speed = 10f;
	public float rotateSpeed = 20f;

	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	void FixedUpdate () {
		Vector2 direction = (Vector2)target.position - rb.position;
		direction.Normalize();
		float rotateAmount = Vector3.Cross(direction, transform.up).z;
		rb.angularVelocity = rotateAmount * -rotateSpeed;
		rb.velocity = transform.up * speed;
	}
	void OnTriggerEnter2D ()
	{
		Destroy(gameObject);
	}

}

