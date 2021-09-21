using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class LayOutRForEnemy : MonoBehaviour
{
	PathFinder Path = new PathFinder();

    // Use this for initialization
	private Rigidbody rbody;
    public bool[,] map = new bool[10, 10];
	private GameObject enemy;
	Vector2Int startPos;
	Vector2Int goal;
	List<Vector3> path;

	void Start(){
		enemy = GameObject.Find ("Enemy");
		rbody = enemy.GetComponent<Rigidbody> ();
		map = GameObject.Find ("MapGenerator").GetComponent<LayingOutRoute> ().map;
	}
    // Update is called once per frame

    void Update()
    {   
		if (Input.GetMouseButtonDown (0)) {
			startPos = new Vector2Int ((int)enemy.transform.position.x, (int)enemy.transform.position.z);
			var finish = GameObject.Find ("Mooshroom").transform.position;
			goal = new Vector2Int ((int)finish.x, (int)finish.z);
			var path = Path.FindPath (map, startPos, goal);
	
			if (path != null) {
				enemy.GetComponent<CharacterMovement> ().SetPath (path);
			} else {
				Debug.Log ("No route available");
			}
		}
	}
}
