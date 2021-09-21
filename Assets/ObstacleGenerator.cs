using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour {

	public GameObject obstacle;
	void Start () 
	{
		for (int i = 0; i < 15; i++) 
		{
			int x = (Random.Range (1, 9));
			int z = (Random.Range (1, 9));
			var o = Instantiate (obstacle, new Vector3 (x, 0, z), Quaternion.identity, transform);
			o.name = "TreeObstacle" + (i+1);
			o.transform.parent = transform; //transform отовсюду можно убрать
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
