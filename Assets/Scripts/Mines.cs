using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Mines Started");
		Debug.Log("Pos x: " + this.transform.position.x + " y: " + this.transform.position.y);
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -15f)	
			Destroy(this.gameObject);
	}
}
