﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Action : MonoBehaviour
{
    public enum Type { Tree, Well };
    public Type type;
    public PlayerVariables player;

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerVariables>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") player.nextObject = this;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" && player.nextObject == this) player.nextObject = null;
    }

    public void executeAction()
    {
        if (type == Type.Tree)
        {
            player.wood += 5;
            //Destroy(gameObject);
            GetComponent<DestroyObject>().StartDeath();
        }
        else if (type == Type.Well)
        {
            player.water += 5;
        }
    }

}
