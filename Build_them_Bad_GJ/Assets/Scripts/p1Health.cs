using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (ShipAttributes.p1_hit == true)
		{
			ShipAttributes.p1_health -= 1;
			Debug.Log("Player shields: " + ShipAttributes.p1_shieldChance);
			Debug.Log("Player 1 health: " + ShipAttributes.p1_health);
		}
		else
		{
			Debug.Log("Player evaded hit");
		}
		
	}
}
