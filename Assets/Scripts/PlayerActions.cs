using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    PlayerVariables vars;

    private void Start()
    {
        vars = GetComponent<PlayerVariables>();
    }

    void Update()
    {
        if (Input.GetKey("c") && vars.nextObject != null)
        {
            vars.nextObject.executeAction();
        }
    }
}
