using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform player;
    public Transform follow;
    public float speed = 2f;
    Transform planet;

    private void Start()
    {
        planet = GameObject.FindGameObjectWithTag("Planet").transform;
    }

    void Update () {
        transform.position = Vector3.Lerp(transform.position, follow.position, speed * Time.deltaTime);
        transform.LookAt(player, (transform.position - planet.position).normalized);
	}
}
