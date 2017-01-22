using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinesManager : MonoBehaviour {
	public float speed = 10f;
	public Vector2 start;
	public GameObject Mine;

	// Use this for initialization
	void Start () {
		Invoke("SpawnMines", Random.Range(5f / speed, 60f / speed));
	}

	// Update is called once per frame
	void Update () {

	}

	void SpawnMines() {
		Quaternion r = Quaternion.Euler(Random.Range(0, 1) * 180, Random.Range(0, 1) * 180, 0);
		GameObject test = Instantiate(Mine, new Vector3( start.x, start.y, 0f), r) as GameObject;
		test.transform.localPosition = new Vector3(Random.Range(-4f, 14f), Random.Range(6f, 8f), 0f);
		Invoke("SpawnMines", Random.Range(5f / speed, 60f / speed));
	}
}