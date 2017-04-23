using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrectRotation : MonoBehaviour
{
    Transform planet;

    private void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
        ApplyCorrection();
    }

    private void Update()
    {
        ApplyCorrection();
    }

    void ApplyCorrection()
    {
        Vector3 normal = (transform.position - planet.position).normalized;

        float diff = Vector3.Angle(transform.up, normal);
        Vector3 axis = Vector3.Cross(transform.up, normal);
        transform.RotateAround(transform.position, axis, diff);
    }
}
