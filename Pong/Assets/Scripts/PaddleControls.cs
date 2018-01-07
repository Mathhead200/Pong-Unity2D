using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControls : MonoBehaviour {

	[Tooltip("Player who will be controlled.")]
	public Player player = Player.LEFT;
	
	[Tooltip("Units per second the paddle will move when the input axis is maxed out at 1 or -1.")]
	public float speed = 10;

	[Tooltip("The lowest y coordinate the paddle can move to.")]
	public float minY = -3;

	[Tooltip("The lowest y coordinate the paddle can move to.")]
	public float maxY = 3;


	// Use this for initialization
	// void Start() {}


	// Update is called once per frame
	void Update() {
		float vel = Input.GetAxisRaw( player.getVerticalAxis() );
		if( vel != 0 ) {
			transform.position += new Vector3(0, speed * vel * Time.deltaTime, 0);
			transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, minY, maxY), transform.position.z);
		}
	}

}
