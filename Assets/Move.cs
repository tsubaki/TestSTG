using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {


	void FixedUpdate () {

		float v = Input.GetAxisRaw("Vertical");
		float h = Input.GetAxisRaw("Horizontal");

		rigidbody2D.velocity = new Vector3(h, v, 0);
	}


	void OnTriggerEnter2D(Collider2D coll) {

		Destroy (gameObject);
		GameObject.FindWithTag("GameController").SendMessage("PlayerDead");

	}
}
