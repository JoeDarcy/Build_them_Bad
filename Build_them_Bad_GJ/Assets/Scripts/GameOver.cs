using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
	[SerializeField] private float sceneTimer = 0.0f;
    private float timer = 0.0f;

	private void Start()
	{
		timer = sceneTimer;
	}

	// Update is called once per frame
	void Update()
    {
	    if (ShipAttributes.p1_health <= 0 || ShipAttributes.p2_health <= 0)
	    {
		    timer -= Time.deltaTime;

		    if (timer <= 0)
		    {
			    SceneManager.LoadScene(4);
			}
	    }
    }
}
