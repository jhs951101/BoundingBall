﻿using UnityEngine;
using System.Collections;

public class BarColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Renderer>().material.color = Color.cyan;
    }
	
	// Update is called once per frame
	void Update () {

    }
}
