using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float score = 0;
    Text text;
	void Start () {
        text = this.GetComponent<Text>();
        text.text = string.Format("Score: {0}", score);
	}
	
	public void AddScore(float amount)
    {
        text.text = string.Format("Score: {0}", score+=amount);
    }
}
