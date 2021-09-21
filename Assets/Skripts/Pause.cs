using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public GameObject myPause;
	private bool ifPause = false;

	// Update is called once per frame
	public void Paused () 
	{
			if (ifPause == false) {
				Time.timeScale = 0;
				ifPause = true;
				myPause.SetActive (true);
				AudioListener.volume = 0;
			}
			else 
			{
				Time.timeScale = 1;
				ifPause = false;
				myPause.SetActive (false);
				AudioListener.volume = 1;
			}
	}
}
