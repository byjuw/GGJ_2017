using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torpedo : MonoBehaviour {
    private GameObject rdr;
    public GameObject RadarPoint;
    private bool has_been_destroyed = false;
    public Vector2 startPos;

    // Use this for initialization
    void Start () {
        rdr = Instantiate(RadarPoint, new Vector3(this.transform.position.x > 0 ? 7.5f : -7.5f, this.transform.position.y, 0), Quaternion.identity);
        startPos = this.transform.position;
    }

    // Update is called once per frame
    void Update () {
        if (rdr && rdr.gameObject) {
            Color tmp = rdr.GetComponent<SpriteRenderer>().color;
            tmp.a = 1 - Mathf.Abs(rdr.transform.position.x - this.transform.position.x) / Mathf.Abs(rdr.transform.position.x - Mathf.Abs(startPos.x));
            rdr.GetComponent<SpriteRenderer>().color = tmp;
        }
        int fact = this.GetComponent<Rigidbody2D>().velocity.x > 0 ? 1 : -1;
        if ( ( this.transform.position.x > 45 || this.transform.position.x < -45 )  && fact * this.transform.position.x > 0 ) {
            Destroy(this.gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D coll) {
        Destroy(rdr.gameObject);
    }
}
