﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour {

    void Awake()
    {
        SingletonUse.willToLive--;
    }
}
