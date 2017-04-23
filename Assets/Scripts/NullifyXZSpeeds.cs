using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullifyXZSpeeds : MonoBehaviour {
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

	void Update () {
        rb.velocity = transform.up.normalized * Vector3.Dot(transform.up, rb.velocity);
        rb.angularVelocity = Vector3.zero;
	}
}
