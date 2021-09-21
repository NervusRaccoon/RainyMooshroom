using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class MouseCamera : MonoBehaviour {


	/*public Transform target;
	public player mask;
	public MouseCamera player;
	private Vector3 direction;*/
	/*public Vector3 teleportPoint;
    public GameObject player;
	public Rigidbody rb;
	RaycastHit hit;

	void Start() {
		rb = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Fire1")) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit))
			{
				if ((hit.collider.CompareTag("Ground")) || (hit.collider.CompareTag("Finish")))
				player.transform.position = new Vector3(hit.point.x, -0.15f, hit.point.z);

			}
		}
			
	}


    void FixedUpdate()
    {
		rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
    }

}*/