﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

    public static bool goalflag;
    private string anserword;
    // Use this for initialization
    void Start () {

        goalflag = false;
        anserword = "1594";

    }

    // Update is called once per frame
    void Update () {
    
        if (buttonclick.anwer == anserword)
        {
            goalflag = true;
        }

	}
}