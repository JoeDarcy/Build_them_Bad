using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] Transform p1FirePoint;
    public GameObject bulletPrefab;

    private GameObject bulletInstance = null;

    [SerializeField] private Transform p1Target = null;
    [SerializeField] private Transform p2Target = null;

    void Update()
    {
        if (gameObject.CompareTag("Player_1"))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                bulletInstance = Instantiate(bulletPrefab, p1FirePoint.position, p1FirePoint.rotation);
            }
        }
        if (gameObject.CompareTag("Player_2"))
        {
	        if (Input.GetKeyDown(KeyCode.KeypadEnter)) {
		        bulletInstance = Instantiate(bulletPrefab, p1FirePoint.position, p1FirePoint.rotation);
	        }
        }
    }
}
