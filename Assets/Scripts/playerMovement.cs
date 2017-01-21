using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float acceleration_x = 10f;
    public float acceleration_y = 8f;
    public float drag_x = 1.5f;
    public float drag_y = 2f;
    public float angular_drag = 1f;
    public float angular_acceleration = 45f;
    public float steady = 2f;
    float angular_speed = 0f;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // velocity += acceleration - drag
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(rb.velocity.x + (Input.GetAxis("Horizontal") * acceleration_x - drag_x * rb.velocity.x) * Time.deltaTime, rb.velocity.y + (Input.GetAxis("Vertical") * acceleration_y - drag_y * rb.velocity.y) * Time.deltaTime);
        angular_speed += Time.deltaTime * (Input.GetAxis("Vertical") * angular_acceleration - angular_speed * angular_drag);
        float steadying;
        if (this.transform.eulerAngles.z > 180) steadying = (this.transform.eulerAngles.z - 360) * steady;
        else steadying = this.transform.eulerAngles.z * steady;
        transform.rotation = Quaternion.Euler(0, 0, this.transform.eulerAngles.z + Time.deltaTime * (angular_speed - steadying));
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("Boom!!!");
        Application.LoadLevel("gameOver");
    }
}
