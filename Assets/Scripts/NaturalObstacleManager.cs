using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaturalObstacleManager : MonoBehaviour {
    public float speed = 1f;
    public Vector2 start;
    public GameObject[] Rocks;

    // Use this for initialization
    void Start () {
        if (speed == 0f)
            return ;
        Invoke("SpawnNaturalObstacle", Random.Range(2f / speed, 6f / speed));
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnNaturalObstacle() {
        if (speed == 0f)
            return;
        Quaternion r = Quaternion.Euler(Random.Range(0, 1) * 180, Random.Range(0, 1) * 180, Random.Range(0, 3) * 90);
        GameObject test = Instantiate(Rocks[Random.Range(0, Rocks.Length)], new Vector3( start.x, start.y, 0f), r) as GameObject;
        test.transform.localScale = new Vector3(Random.Range(0.3f, 1f), Random.Range(0.4f, 1f), 0f);
        test.GetComponent<NaturalObstacle>().setSpeed(speed);
        Invoke("SpawnNaturalObstacle", Random.Range(2f / speed, 6f / speed));
    }
}
