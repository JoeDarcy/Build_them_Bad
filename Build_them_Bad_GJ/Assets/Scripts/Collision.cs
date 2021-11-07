using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	[SerializeField] private GameObject hitFX = null;
	private GameObject hitInstance = null;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		hitInstance = Instantiate(hitFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
	}
}
