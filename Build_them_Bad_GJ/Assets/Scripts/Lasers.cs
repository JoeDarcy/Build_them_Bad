using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasers : MonoBehaviour
{
    [SerializeField] private GameObject p1_laser_1 = null;
    [SerializeField] private GameObject p1_laser_2 = null;
    [SerializeField] private GameObject p1_laser_3 = null;
    private GameObject p1_laserChoice = null;

    [SerializeField] private GameObject p2_laser_1 = null;
    [SerializeField] private GameObject p2_laser_2 = null;
    [SerializeField] private GameObject p2_laser_3 = null;
    private GameObject p2_laserChoice = null;

    // Laser fire rate timers 
    public static float p1_laserRate = 0.0f;
    private float p1_timer = 0.0f;
	private float p1_laserKillTimer = 0.5f;

    public static float p2_laserRate = 0.0f;
    private float p2_timer = 0.0f;
    private float p2_laserKillTimer = 0.5f;

	// Start is called before the first frame update
	void Start()
    {
	    p1_timer = p1_laserRate;
	    p2_timer = p2_laserRate;
    }

    // Update is called once per frame
    void Update()
    {
	    if (ShipBuilding.p1_specialWeaponStrength == 1) {
		    p1_laserChoice = p1_laser_1;
		    p1_laserRate = Random.Range(6, 8);
	    } else if (ShipBuilding.p1_specialWeaponStrength == 2) {
		    p1_laserChoice = p1_laser_2;
		    p1_laserRate = Random.Range(5, 8);
        } else if (ShipBuilding.p1_specialWeaponStrength == 3) {
		    p1_laserChoice = p1_laser_3;
		    p1_laserRate = Random.Range(4, 8);
        }

	    if (ShipBuilding.p2_specialWeaponStrength == 1) {
		    p2_laserChoice = p2_laser_1;
		    p2_laserRate = Random.Range(6, 8);
        } else if (ShipBuilding.p1_specialWeaponStrength == 2) {
		    p2_laserChoice = p2_laser_2;
		    p2_laserRate = Random.Range(5, 8);
        } else if (ShipBuilding.p1_specialWeaponStrength == 3) {
		    p2_laserChoice = p2_laser_3;
		    p2_laserRate = Random.Range(4, 8);
        }


	    // Player 1 Lasers
		if (p1_timer >= 0)
	    {
		    p1_timer -= Time.deltaTime;
	    }

	    if (p1_timer < 0)
	    {
		    p1_laserChoice.SetActive(true);
		    p1_timer = p1_laserRate;
		    p1_laserKillTimer = 0.5f;
	    }

	    if (p1_laserKillTimer > 0)
	    {
		    p1_laserKillTimer -= Time.deltaTime;
	    }
	    else
	    {
		    p1_laserChoice.SetActive(false);
		}

		

		// Player 2 Lasers
	    if (p2_timer > 0) {
		    p2_timer -= Time.deltaTime;
	    }

	    if (p2_timer < 0) {
		    p2_laserChoice.SetActive(true);
		    p2_timer = p2_laserRate;
		    p2_laserKillTimer = 0.5f;
		}

	    if (p2_laserKillTimer > 0) {
		    p2_laserKillTimer -= Time.deltaTime;
	    } else {
		    p2_laserChoice.SetActive(false);
	    }


		Debug.Log("Player 1 laser choice: " + p1_laserChoice);
	    Debug.Log("Player 2 laser choice: " + p2_laserChoice);
	    Debug.Log("Player 1 laser rate: " + p1_laserRate);
	    Debug.Log("Player 2 laser rate: " + p2_laserRate);
    }
}
