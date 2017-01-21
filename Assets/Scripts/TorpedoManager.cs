using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoManager : MonoBehaviour {

    public Rigidbody2D Torpedo;
    public float b_inf_x = -5f;
    public float b_sup_x = 5f;
    public float b_inf_y = 0f;
    public float b_sup_y = 1f;
    public float freq = 1f;
    public float speed = 10f;

    float random_borne_x ()
    {
        float rand = b_inf_x + (b_sup_x - b_inf_x) * Random.value;
        if ( Random.value > .5 ) return rand;
        else return -rand;
    }

    float random_borne_y ()
    {
        return b_inf_y + (b_sup_y - b_inf_y) * Random.value;
    }

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        if ( Random.value < freq ) {
            float rand_x = random_borne_x();
            int fact = rand_x > 0 ? 1 : -1;
            int fact2 = rand_x > 0 ? 0 : 1;
            Rigidbody2D torpedo_instance = Instantiate(Torpedo, new Vector3(rand_x, random_borne_y(), 0), Quaternion.Euler(0, fact2 * 180, 0));
            torpedo_instance.velocity = new Vector3(-fact * speed, 0, 0);
        }
	}
}
