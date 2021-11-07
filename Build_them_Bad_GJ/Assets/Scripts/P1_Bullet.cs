using System;
using System.Collections;
using System.Collections.Generic;
//using UnityEditor.PackageManager;
using UnityEngine;

   [RequireComponent(typeof(Rigidbody2D))]
public class P1_Bullet : MonoBehaviour
{
    private Transform p1Target;

	public float speed = 10f;
	public float rotateSpeed = 20f;

	public Rigidbody2D rb;

	private void Awake()
	{
		p1Target = GameObject.FindGameObjectWithTag("Player_2").transform;
		Debug.Log(p1Target.name);
	}

	void FixedUpdate () {
		Vector2 direction = (Vector2)p1Target.position - rb.position;
		direction.Normalize();
		float rotateAmount = Vector3.Cross(direction, transform.up).z;
		rb.angularVelocity = rotateAmount * -rotateSpeed;
		rb.velocity = transform.up * speed;
	}

	void OnTriggerEnter2D(Collider2D hit)
	{
		if (gameObject.CompareTag("Player_2"))
		{
			Debug.Log(hit.name);
			Destroy(gameObject);
		}
	}

}

