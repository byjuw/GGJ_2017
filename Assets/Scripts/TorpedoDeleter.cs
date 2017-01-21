using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoDeleter : MonoBehaviour {

    public Rigidbody2D Torpedo;
    public GameObject RadarPoint;
    private GameObject rdr;
    private bool has_been_destroyed = false;

    // Use this for initialization
    void Start () {
        rdr = Instantiate(RadarPoint, new Vector3(this.transform.position.x > 0 ? 6.5f : -6.5f, this.transform.position.y, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update () {
        if ( !has_been_destroyed && (this.transform.position.x > 9 || this.transform.position.x < -9) )
        {
            has_been_destroyed = true;
            Destroy(rdr);
        }
        else if ( !has_been_destroyed )
        {
            rdr.GetComponent<Renderer>().material.color.a = .5f;
        }
        int fact = this.GetComponent<Rigidbody2D>().velocity.x > 0 ? 1 : -1;
        if ( ( this.transform.position.x > 15 || this.transform.position.x < -15 )  && fact * this.transform.position.x > 0 ) {
            Destroy(this.gameObject);
        }
	}
}
