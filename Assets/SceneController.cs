﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {

    public GameObject prefabWall;
    float delayUntilSpawn = 0;
    bool wallRight = false;
    bool wallMid = false;
    bool wallLeft = false;
    float whichLane = 0;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        delayUntilSpawn -= Time.deltaTime;
        if (delayUntilSpawn <= 0)
        {
            whichLane = Random.Range(1, 4);
            print(whichLane);
            if (whichLane == 1)
            {
                if (wallLeft == false)
                {
                    wallMid = false;
                    wallLeft = true;
                    wallRight = false;
                    Vector3 pos = new Vector3(-4, 0, 20);
                    Instantiate(prefabWall, pos, Quaternion.identity);
                    delayUntilSpawn = Random.Range(1, 3);
                }

            } else if (whichLane == 2)
            {
                if (wallMid == false)
                {
                    wallMid = true;
                    wallLeft = false;
                    wallRight = false;
                    Vector3 pos = new Vector3(0, 0, 20);
                    Instantiate(prefabWall, pos, Quaternion.identity);
                    delayUntilSpawn = Random.Range(1, 3);
                }
                
            } else if (whichLane == 3)
            {
                if(wallRight == false)
                {
                    wallMid = false;
                    wallLeft = false;
                    wallRight = true;
                    Vector3 pos = new Vector3(4, 0, 20);
                    Instantiate(prefabWall, pos, Quaternion.identity);
                    delayUntilSpawn = Random.Range(1, 3);
                }
            }
        }
	}
}
