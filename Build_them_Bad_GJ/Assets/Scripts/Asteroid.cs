using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
	[SerializeField] private float dropSpeed = 0.0f;

    // Update is called once per frame
    void Update()
    {
	    transform.position = new Vector3(transform.position.x, transform.position.y - dropSpeed, transform.position.z);
    }
}
