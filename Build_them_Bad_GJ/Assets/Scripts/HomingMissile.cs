using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HomingMissile : MonoBehaviour
{
    public Transform target = null;
    public Rigidbody missileRb;
    public float speed = 25.0f;
    public float rotateSpeed = 2.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        missileRb.velocity = transform.forward * speed;
        var rotateAmount = Quaternion.LookRotation(target.position - transform.position);
        missileRb.MoveRotation(Quaternion.RotateTowards(transform.rotation, rotateAmount, rotateSpeed));  
    }
}
