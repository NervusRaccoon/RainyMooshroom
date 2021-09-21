using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	public float speed;
	public Transform target;
	private Rigidbody rig;
	private List<Vector2Int> path;
	private Vector3 movePos;

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();
		path = new List<Vector2Int> ();
		movePos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		rig.MovePosition(Vector3.MoveTowards(transform.position, movePos, Time.deltaTime * speed));
		if (path == null || path.Count == 0)
			return;
		//new
		//Vector3 relativePos = target.position - transform.position;
		//Quaternion rotation = Quaternion.LookRotation(relativePos, Vector3.up);
		//transform.rotation = rotation;	
		//new
		//transform.LookAt(movePos);
		if ((movePos - transform.position).sqrMagnitude < 0.01f) {
			transform.position = movePos;
			path.RemoveAt (0);
			if (path.Count > 0) {
				var pos = path [0];
				movePos = new Vector3 (pos.x, transform.position.y, pos.y);
				transform.LookAt (movePos, Vector3.up);
			}
		}
	}

	public void SetPath(List<Vector2Int> newPath){
		path = newPath;
	}
}
