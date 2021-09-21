using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class MousePerson : MonoBehaviour {

	CharacterController player;
	public float radiusNoClick = 3f;
	public Vector3 target = Vector3.zero;
	private Vector3 direction;
	public float speedRotation = 3f;
	public float speedMove = 8f;
	private bool onPlace = true;
	private Animation _animation;

	enum CharacterState {
		Idle = 0,
		Walking = 1,
	}

	private CharacterState _characterState;

	// Use this for initialization
	void Start () {
		_animation = GetComponent ();
		player = (CharacterController)gameObject.GetComponent (typeof(CharacterController));
	}
	
	// Update is called once per frame
	void Update () {

		if (!onPlace) {
			direction = target - this.transfrorm.position;
			direction = new Vector3(direction.x, 0, direction.z);
			direction.Normalize();

			Quaternion look = Quaternion.LookRotation(direction);
			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, look, Time.deltaTime * speedRotation);

			player.Move(direction * Time.deltaTime * speedMove);

			_characterState = CharacterState.Walking;
		}
		else {
			_characterState = CharacterState.Idle;
		}

		if (_animation) {
			if (_characterState == CharacterState.Walking)
				_animation.Play("walk", PlayMode.StopAll);
			else if (_characterState = CharacterState.Idle)
				_animation.Play("idle", PlayMode.StopAll);
		}
	}

	public void GetTarget(Vector3 target) {
		if (((Mathf.Abs(transform.position.x - target.x) >= radiusNoClick) &&
			(Mathf.Abs(transform.position.z - target.z) >= radiusNoClick)) 
			{
				this.target = target;
				onPlace = false;
			}}
		
		public void OnPlaceTrue() {
			onPlace = true;	
			}
	}

*/