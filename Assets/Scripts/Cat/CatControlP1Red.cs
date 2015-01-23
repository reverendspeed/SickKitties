using UnityEngine;
using System.Collections;

public class CatControlP1Red : MonoBehaviour {
	private	CatMove		catMove;
	private Vector3 	moveDirection = Vector3.zero;
	
	void Awake () {
		catMove 		= GetComponent<CatMove> ();
	}
	
	void Update() {
		moveDirection 	= new Vector3(Input.GetAxis("L_XAxis_1"), 0, Input.GetAxis("L_YAxis_1"));
		bool	jump	= Input.GetButtonDown("A_1");
		catMove.MoveCat(moveDirection, jump);
	}
}
