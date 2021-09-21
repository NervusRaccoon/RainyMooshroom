using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTracking : MonoBehaviour 
{
	public Material original; 
	public Material selected;
	public GameObject noSelect;
    void Update()
    {
		RaycastHit hit;
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.CompareTag ("Ground")) {
				if (hit.collider.gameObject != noSelect) 
				{
					noSelect.GetComponent<MeshRenderer> ().material = original;
				}
				hit.collider.gameObject.GetComponent<MeshRenderer> ().material = selected;
				noSelect = hit.collider.gameObject;
			}
			if (hit.collider.CompareTag ("Finish")) {
				noSelect.GetComponent<MeshRenderer> ().material = original;
			}
			//Instantiate (particle, new Vector3 (hit.point.x, hit.point.y, hit.point.z), Quaternion.identity);
		} else 
		{
			noSelect.GetComponent<MeshRenderer> ().material = original;
		}
	}
}

