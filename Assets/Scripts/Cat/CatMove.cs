using UnityEngine;
using System.Collections;

public class CatMove : MonoBehaviour {

	public 	Transform 	catRotate;
	public 	float 		speed 		= 6.0F;
	public 	float 		jumpSpeed 	= 8.0F;
	public 	float 		gravity 	= 20.0F;

	private CharacterController controller;

	private Vector3		moveDirection;

	void	Awake () {
		controller = GetComponent<CharacterController>();
	}

	public	void MoveCat (Vector3 inputMoveDirection, bool jump) {
		if (controller.isGrounded) {
			moveDirection = inputMoveDirection;
			moveDirection = transform.TransformDirection(moveDirection);
			if(moveDirection != Vector3.zero)Rotate (moveDirection);
			moveDirection *= speed;
			if (jump)	moveDirection.y = jumpSpeed;
		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	void Rotate(Vector3 catTarget){
		Quaternion rotation = Quaternion.LookRotation(catTarget);
		catRotate.rotation = rotation;
	}
}
