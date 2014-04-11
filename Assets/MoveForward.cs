using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

	public float speed = 1;

	void Start()
	{
		Destroy (gameObject, 5);
	}

	void FixedUpdate () {

		rigidbody2D.velocity = transform.up * -speed;
	
	}
}
