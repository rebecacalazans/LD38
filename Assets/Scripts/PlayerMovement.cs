using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 5f, angularSpeed = 90f;

	void FixedUpdate () {
        if (Input.GetKey("up")) {
            transform.position += transform.forward.normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey("down")) {
            transform.position -= transform.forward.normalized * speed * Time.deltaTime;
        }
        if (Input.GetKey("left")) {
            transform.RotateAround(transform.position, transform.up, -angularSpeed * Time.deltaTime);
        }
        if (Input.GetKey("right")) {
            transform.RotateAround(transform.position, transform.up, angularSpeed * Time.deltaTime);
        }
	}
}