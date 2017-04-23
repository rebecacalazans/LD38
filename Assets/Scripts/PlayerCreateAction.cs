using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreateAction : MonoBehaviour
{
    public GameObject prefabTree, prefabWell;
    public GameObject obj = null;
    public Transform createPosition;

    void Update()
    {
        if (Input.GetKey("a"))
        {
            if (obj != null) Destroy(obj);
            obj = Instantiate(prefabTree, createPosition.transform.position, createPosition.transform.rotation, transform);
        }

        if (Input.GetKey("esc"))
        {
            if (obj != null) Destroy(obj);
            obj = null;
        }
    }
}