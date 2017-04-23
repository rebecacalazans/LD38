using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour {
    public Transform planet;
    public Transform baseTransform;
    public float accel = 5f;

    float distToGround;

    Rigidbody rb;

    void Start() {
        distToGround = GetComponent<Collider>().bounds.extents.y;
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        Vector3 normal = (baseTransform.position - planet.position).normalized;

        if (!isGrounded()) {
            rb.AddForce(-normal * accel);
        }
    }

    public bool isGrounded()
    {
        return Physics.Raycast(transform.position, -transform.up, distToGround + 0.1f);
    }
}
