using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
	[SerializeField] private GameObject asteroid = null;
	private GameObject asteroidInstance = null;
	private float spawnRate = 0.0f;
	private float timer = 0.0f;
	private float randomPosition = 0.0f;

	// Start is called before the first frame update
	void Start() {
		timer = spawnRate;
	}

	// Update is called once per frame
	void Update() {
		timer -= Time.deltaTime;

		randomPosition = Random.Range(-3, 3);

		spawnRate = Random.Range(1, 3);

		if (timer <= 0)
		{
			asteroidInstance = Instantiate(asteroid, new Vector3(transform.position.x + randomPosition, transform.position.y, transform.position.z), asteroid.transform.rotation);
			timer = spawnRate;
		}
	}
}
