using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGravity : MonoBehaviour {
    public Transform planet;
    public Transform baseTransform;
    public float accel = 10;
    public bool onGround = false;

    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update () {
        Vector3 normal = (baseTransform.position - planet.position).normalized;

        float diff = Vector3.Angle(transform.up, normal);
        Vector3 axis = Vector3.Cross(transform.up, normal);
        transform.RotateAround(baseTransform.position, axis, diff);

        if (!onGround) {
            rb.AddForce(- normal * accel);
        }
    }

    void OnCollisionEnter(Collision collision) {
        if (!onGround && collision.gameObject.tag == "World") {
            onGround = true;
            rb.velocity.Set(0, 0, 0);
        }
    }
}
