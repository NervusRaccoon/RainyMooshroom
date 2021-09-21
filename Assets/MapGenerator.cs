using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour {

	public GameObject tile;
	void Start () {
		var count = 0;
		for (int z = 0; z < 10; z++) {	
	      for (int x = 0; x < 10; x++) {
			count++;
	        var b = Instantiate (tile, new Vector3(x,0,z), Quaternion.identity);
			b.name = "LandElement" + count;
	        }
		}}
			
	
	// Update is called once per frame
	void Update () {
		
	}
}
