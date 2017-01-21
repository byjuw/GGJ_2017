using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalObstacle : MonoBehaviour {
    private float _speed;

	// Use this for initialization
	void Start () {
        Debug.Log("Natural Obstacle Started");
        Debug.Log("Pos x: " + this.transform.position.x + " y: " + this.transform.position.y);
	}
	
	// Update is called once per frame
	void Update () {
        if (this.transform.position.x < -15f)
            Destroy(this.gameObject);
        else
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-_speed, 0f);
	}

    public void setSpeed(float speed) {
        _speed = speed;
    }
}
