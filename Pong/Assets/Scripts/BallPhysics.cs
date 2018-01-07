using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPhysics : MonoBehaviour {

	[Tooltip("How fast the ball should start moving in units per second.")]
	public float initialSpeed = 4f;

	private Rigidbody2D rb;
	private Vector3 initialPosition;

	private void randomizeVelocity() {
		rb.velocity = initialSpeed * new Vector3( Random.value >= 0.5 ? 1 : -1, Random.Range(-1f, 1f), 0 );
		Debug.Log(rb.velocity);
	}

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		initialPosition = rb.position;
		randomizeVelocity();
	}

	// callback for collisions
	private void OnCollisionEnter2D(Collision2D collision) {
		// TODO: use direction of colliding paddle to change velocity of ball in the same direction (somewhat)
		// TODO: speed up ball on inpact with paddle
		// TODO: score point when colliding with goal

		string name = collision.gameObject.name;
		Debug.Log( "Ball collided with " + name );
		if( name.Contains("Goal") ) {
			rb.position = initialPosition;
			randomizeVelocity();
			// TODO: score point
		}
	}
}
