using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsManager : MonoBehaviour {
	public float speed = 1f;
	public Vector2 start;
	public GameObject[] Animals;

	// Use this for initialization
	void Start () {
		if (speed == 0f)
			return ;
		Invoke("SpawnAnimals", Random.Range(10f / speed, 100f / speed));
	}

	// Update is called once per frame
	void Update () {

	}

	void SpawnAnimals() {
		if (speed == 0f)
			return;
		Quaternion r = Quaternion.Euler(Random.Range(0, 1) * 180, Random.Range(0, 1) * 180, 0);
		GameObject test = Instantiate(Animals[Random.Range(0, Animals.Length)], new Vector3( start.x, start.y, 0f), r) as GameObject;
		test.transform.localPosition = new Vector3(20f, Random.Range(-2f, 4f), 0f);
		test.GetComponent<Animals>().setSpeed(speed);
		Invoke("SpawnAnimals", Random.Range(10f / speed, 100f / speed));
	}
}