using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemysTrigger : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Finish") 
		{
			SceneManager.LoadScene(15);
		}
	}
}
