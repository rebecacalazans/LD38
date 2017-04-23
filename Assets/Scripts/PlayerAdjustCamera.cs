using UnityEngine;

public class PlayerAdjustCamera : MonoBehaviour {
    public Transform cameraPosition;
    public Vector3 backwardsDelta;
    public Vector3 forwardDelta;

	void Update () {
        if (Input.GetKeyDown("down"))
            cameraPosition.localPosition = cameraPosition.localPosition + backwardsDelta;
        if (Input.GetKeyUp("down"))
            cameraPosition.localPosition = cameraPosition.localPosition - backwardsDelta;

        if (Input.GetKeyDown("up"))
            cameraPosition.localPosition = cameraPosition.localPosition + forwardDelta;
        if (Input.GetKeyUp("up"))
            cameraPosition.localPosition = cameraPosition.localPosition - forwardDelta;
	}
}
