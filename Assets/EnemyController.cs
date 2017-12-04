using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public Score score;
    public Target[] enemies;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(score.score >= 100)
        {
            enemies[1].enabled = true;
        }
        else if (score.score >= 200)
        {
            enemies[2].enabled = true;
        }
        else if (score.score >= 400)
        {
            enemies[3].enabled = true;
        }
        else if (score.score >= 800)
        {
            enemies[4].enabled = true;
        }
        else if (score.score >= 1600)
        {
            enemies[5].enabled = true;
        }
        else if (score.score >= 3200)
        {
            enemies[6].enabled = true;
        }
    }
}
