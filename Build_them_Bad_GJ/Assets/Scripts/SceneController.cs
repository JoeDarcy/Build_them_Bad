using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
	[SerializeField] private int sceneToLoad;
	[SerializeField] private GameObject playButtonGreyOut = null;
	[SerializeField] private GameObject playButton = null;
	private bool playGamePressed = false;

	public void PlayGame()
	{
		playGamePressed = true;
	}

	private void Start() {
		playButton.SetActive(false);
	}

	private void Update() {
		if (ShipBuilding.shipBuildingComplete == true)
		{
			playButtonGreyOut.SetActive(false);
			playButton.SetActive(true);

			if (playGamePressed == true)
			{
				SceneManager.LoadScene(sceneToLoad);
			}
		}
		else
		{
			playButtonGreyOut.SetActive(true);
			playButton.SetActive(false);
		}
	}
}
