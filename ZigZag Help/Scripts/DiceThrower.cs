using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceThrower : MonoBehaviour {

    public Text hiScore, score;
    int HighScore, Score;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Score = Random.Range(1, 50);
            score.text = Score.ToString();

            if (Score > HighScore)
            {
                HighScore = Score;
                hiScore.text = HighScore.ToString();
            }
        }

	}
}
