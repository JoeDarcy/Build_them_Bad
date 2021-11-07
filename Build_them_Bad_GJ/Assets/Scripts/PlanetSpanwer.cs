using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSpanwer : MonoBehaviour
{
    [SerializeField] private GameObject moon = null;
    [SerializeField] private GameObject mercury = null;
    [SerializeField] private GameObject vensus = null;
    [SerializeField] private GameObject mars = null;
    [SerializeField] private GameObject jupiter = null;
    [SerializeField] private GameObject saturn = null;
    [SerializeField] private GameObject uranus = null;
    [SerializeField] private GameObject neptune = null;

    private int planetDiceRoll = 0;
	private GameObject planet = null;
	private GameObject planetInstance = null;
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

		randomPosition = Random.Range(-2, 8);

		spawnRate = Random.Range(3, 8);

		planetDiceRoll = Random.Range(1, 8);

		if (planetDiceRoll == 1)
		{
			planet = moon;
		}
		if (planetDiceRoll == 2) {
			planet = mercury;
		}
		if (planetDiceRoll == 3) {
			planet = mars;
		}
		if (planetDiceRoll == 4) {
			planet = jupiter;
		}
		if (planetDiceRoll == 5) {
			planet = saturn;
		}
		if (planetDiceRoll == 6) {
			planet = uranus;
		}
		if (planetDiceRoll == 7) {
			planet = neptune;
		}
		if (planetDiceRoll == 8) {
			planet = vensus;
		}

		if (timer <= 0) {
			planetInstance = Instantiate(planet, new Vector3(transform.position.x, transform.position.y + randomPosition, transform.position.z), transform.rotation);
			timer = spawnRate;
		}
	}
}
