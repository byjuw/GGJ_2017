using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text countText;
    public Text countValueText;
    private static bool _counting = false;
    private static float _count = 0;

	// Use this for initialization
	void Start () {
        if (countValueText)
            setCountValueText();
        else
            setCountText();
    }
	
	// Update is called once per frame
	void Update () {
        if (_counting == true)
            _count += 5 * Time.deltaTime;
        if (countValueText)
            setCountValueText();
        else
            setCountText();
    }

    void setCountText () {
        countText.text = "Distance: " + ((int)_count).ToString();
    }

    void setCountValueText()
    {
        countValueText.text = ((int)_count).ToString();
    }

    public void setCounting(bool counting) {
        _counting = counting;
    }
}
