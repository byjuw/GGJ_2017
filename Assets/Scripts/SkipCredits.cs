﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipCredits : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space ) || Input.GetKeyDown(KeyCode.Return)) Application.LoadLevel("start");
			
	}
}
