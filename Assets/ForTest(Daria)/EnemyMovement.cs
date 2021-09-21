using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Collections.ObjectModel;
using System;

public class EnemyMovement : MonoBehaviour {

	public float speed = 5;
	private Rigidbody rig;
	private Vector3 movePos;
	private Vector3 finish;
	public Texture2D image;
	public bool[,] map = new bool[10, 10];

	// Use this for initialization
	void Start () {
		rig = GetComponent<Rigidbody>();
		movePos = transform.position;
	}
		
	void Update () {
			rig.MovePosition(Vector3.MoveTowards(transform.position, movePos, Time.deltaTime * speed));
			if ((movePos - transform.position).sqrMagnitude < 0.01f) {
			transform.position = movePos;
				finish = GameObject.Find ("BigJapple").transform.position;
				movePos = finish;
				transform.LookAt (movePos, Vector3.up);
		}
	}

}
