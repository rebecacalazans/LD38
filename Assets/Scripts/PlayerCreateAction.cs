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
        if (Input.GetKeyDown("z"))
        {
            if (obj != null)
            {
                obj.transform.SetParent(null);
                obj = null;
            }
            else {
                obj = Instantiate(prefabTree, createPosition.transform.position, createPosition.transform.rotation, transform);
            }
        }

        if (Input.GetKey("escape"))
        {
            if (obj != null) Destroy(obj);
            obj = null;
        }
    }
}