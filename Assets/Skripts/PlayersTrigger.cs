using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayersTrigger : MonoBehaviour {

	//public GameObject player;
	//public GameObject hand;
	public static bool Finish = false; 
	private Rigidbody rb;
	private bool jap = false;

	void Start()
	{
		Finish = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "japple") 
		{
			/*other.transform.SetParent(hand.transform);
			other.transform.localScale = new Vector3(1f, 2f, 0.6f);
			other.transform.localPosition = new Vector3(0, -1.15f, 0);
			other.transform.localRotation = Quaternion.Euler(0, 0, 0);*/
			Destroy (other.gameObject);
			var enemy = GameObject.FindGameObjectWithTag("Enemy");
			rb = enemy.GetComponent<Rigidbody> ();
			rb.constraints = RigidbodyConstraints.FreezePosition;
			if (!jap) {
				jap = true;
				Invoke ("SomeTime", 1.5f);
			} else 
			{
				CancelInvoke ();
				Invoke ("SomeTime", 1.5f);
				jap = false;
			}
		}			

		if (other.tag == "Finish") 
		{
			Finish = true;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}

	private void SomeTime()
	{
		rb.constraints = RigidbodyConstraints.None;
	}
}
