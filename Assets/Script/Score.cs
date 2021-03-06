using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasePerSecond;

    // Use this for initialization
    void Start () {
        scoreAmount = 0f;
        pointIncreasePerSecond = 1f;

	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = (int)scoreAmount + " Score";
        scoreAmount += pointIncreasePerSecond * Time.deltaTime;
	}
}
