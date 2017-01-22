using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour {
	public float speed = 1f;

	// Use this for initialization
	void Start () {
		Debug.Log("Animals Started");
		Debug.Log("Pos x: " + this.transform.position.x + " y: " + this.transform.position.y);
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.x < -15f)
			Destroy(this.gameObject);
		else
			this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0f);
	}
}
