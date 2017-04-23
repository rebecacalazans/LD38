using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunMovement : MonoBehaviour {
    public float dayLength = 120f;

	void Update () {
        transform.RotateAround(Vector3.zero, transform.right, Time.deltaTime * 360f / dayLength);
	}
}
