using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoDeleter : MonoBehaviour {

    public Rigidbody2D Torpedo;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int fact = this.GetComponent<Rigidbody2D>().velocity.x > 0 ? 1 : -1;
        if ( ( this.transform.position.x > 15 || this.transform.position.x < -15 )  && fact * this.transform.position.x > 0 ) {
            Destroy(this.gameObject);
        }
	}
}
