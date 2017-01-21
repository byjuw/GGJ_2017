using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorpedoManager : MonoBehaviour
{

    public GameObject Torpedo;
    public float entry_x = 15f;
    public float b_inf_y = 0f;
    public float b_sup_y = 1f;
    public double freq = .005f;
    public float speed_min = 6f;
    public float speed_max = 8f;
    public float cooldown = 1f;
    private float cooldown_actual = 0f;

    float random_borne_y()
    {
        return b_inf_y + (b_sup_y - b_inf_y) * Random.value;
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cooldown_actual <= 0 && Random.value < freq)
        {
            float rand_x = Random.value > .5 ? entry_x : -entry_x;
            int fact = rand_x > 0 ? 1 : -1;
            int fact2 = rand_x > 0 ? 0 : 1;
            int variable_de_patch_degueulasse_merci_d_ignorer = 0;
            if (fact2 == 0) variable_de_patch_degueulasse_merci_d_ignorer = 1;
            GameObject torpedo_instance = Instantiate(Torpedo, new Vector3(rand_x, random_borne_y(), 0), Quaternion.Euler(0, fact2 * 180, 0));
            float speed = speed_min + (speed_max - speed_min) * Random.value;
            torpedo_instance.GetComponent<Rigidbody2D>().velocity = new Vector3(-fact * speed - variable_de_patch_degueulasse_merci_d_ignorer, 0, 0);
            cooldown_actual = cooldown;
        }
        else if (cooldown_actual > 0)
        {
            cooldown_actual -= Time.deltaTime;
        }
    }
}