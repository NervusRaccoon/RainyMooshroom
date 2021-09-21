using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLvl : MonoBehaviour {

	void Start()
	{
		Invoke("Switch", 1.5f);
	}

	void Switch()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
