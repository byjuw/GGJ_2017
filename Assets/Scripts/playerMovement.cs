using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    public float acceleration = 1f;
    public float drag = 0.2f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        // velocity += acceleration - drag
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0f, rb.velocity.y + (Input.GetAxis("Vertical") * acceleration * Time.deltaTime) - (drag * rb.velocity.y * Time.deltaTime));
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Boom!!!");
        Application.LoadLevel("gameOver");
    }
}
