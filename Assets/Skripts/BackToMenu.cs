using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour {

	void Start()
	{
		Invoke("Switch", 3.5f);
	}

	void Switch()
	{
		SceneManager.LoadScene (0);
	}
}
