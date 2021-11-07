using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Shooting : MonoBehaviour
{
	[SerializeField] private float shootingSpeed = 0.0f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + shootingSpeed, transform.position.y, transform.position.z);
    }
}
