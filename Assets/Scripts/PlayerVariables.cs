﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVariables : MonoBehaviour
{
    public int food = 100, water = 100, wood = 0;

    [System.NonSerialized]
    public Action nextObject = null;
}
