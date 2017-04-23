using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectRotation : MonoBehaviour {
    public Transform planet;
    public Transform baseTransform;

    void Update () {
        Vector3 normal = (baseTransform.position - planet.position).normalized;

        float diff = Vector3.Angle(transform.up, normal);
        Vector3 axis = Vector3.Cross(transform.up, normal);
        transform.RotateAround(baseTransform.position, axis, diff);
    }
}
