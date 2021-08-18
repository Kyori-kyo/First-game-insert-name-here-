using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour {

	Vector3 velocity;
	Rigidbody myRigidbody;

	void Start () {
		myRigidbody = GetComponent<Rigidbody> ();
	}

	public void Move(Vector3 _velocity) {
		velocity = _velocity;
	}

	public void LookAt(Vector3 lookPoint) {
		Vector3 heightCorrectedPoint = new Vector3 (lookPoint.x, transform.position.y, lookPoint.z);
		transform.LookAt (heightCorrectedPoint);
	}

	public void FixedUpdate() {
		myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);

	}
}