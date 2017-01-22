using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mines : MonoBehaviour {
    public Vector2 speed;

	// Use this for initialization
	void Start () {
        // Debug.Log("Mines Started");
        // Debug.Log("Pos x: " + this.transform.position.x + " y: " + this.transform.position.y);
        

    }

	// Update is called once per frame
	void Update () {
		if (this.transform.position.y < -15f)	
			Destroy(this.gameObject);
        else {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed.x, -speed.y);
        }
    }
}
