using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    public GameObject Score;

	// Use this for initialization
	void Start () {
        Score.GetComponent<Score>().setCount(0);
        Score.GetComponent<Score>().setCounting(true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
