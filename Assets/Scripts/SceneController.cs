using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    // variables for adding walls at random moments
    public GameObject prefabWall;
    public GameObject powerUp;
    int whichRow = 0;
    int whichLane = 0;
    public float fuel = 0;
    //idea: have each lane have a countdown for spawning, and a % chance of spawning in one of the 3 rows
    float delayLeftLane = 0;
    float delayMidLane = 0;
    float delayRightLane = 0;
    float delayHealth = 0;
    //idea, give the player a "blast" that uses up ammo/fuel to break a wall to make up for the possibility of a 9 point spawn


    void Start () {
        //SpawnTrack();
        fuel = 1000;
	}
	
	// Update is called once per frame
	void Update () {
        fuel -= 1;
        delayLeftLane -= Time.deltaTime;
        delayMidLane -= Time.deltaTime;
        delayRightLane -= Time.deltaTime;
        delayHealth -= Time.deltaTime;
        if (delayLeftLane <= 0)
        {
            whichRow = Random.Range(1, 4); //bottom row 1, mid row 2, top row 3 
            SpawnVertical(1, whichRow); //if spawining in the mid lane, lane will always be 1
            delayLeftLane = Random.Range(1, 3);
        }
        if (delayMidLane <= 0)
        {
            whichRow = Random.Range(1, 4); //bottom row 1, mid row 2, top row 3 
            SpawnVertical(2, whichRow); //if spawining in the mid lane, lane will always be 2
            delayMidLane = Random.Range(1, 3);
        }
        if (delayRightLane <= 0)
        {
            whichRow = Random.Range(1, 4); //bottom row 1, mid row 2, top row 3 
            SpawnVertical(3, whichRow); //if spawining in the mid lane, lane will always be 3
            delayRightLane = Random.Range(1, 3);
        }

        //spawn fuel

        //spawn hp
        if(delayHealth <=0)
        {
            whichRow = Random.Range(1, 4);
            whichLane = Random.Range(1, 4);
            SpawnHealth(whichLane, whichRow);
            //delayHealth = Random.Range(6, 10);
         }
        
        
    }
    void SpawnFuel(int lane, int row)
    {
        Vector3 pos = new Vector3();
        
        //check 3 positions on each lane
        if (lane == 1 && row == 1) //left lane
        {
            pos = new Vector3(-4, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 2)
        {
            pos = new Vector3(-4, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 3)
        {
            pos = new Vector3(-4, 2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        if (lane == 2 && row == 1) //mid lane
        {
            pos = new Vector3(0, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 2 && row == 2)
        {
            pos = new Vector3(0, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 2 && row == 3)
        {
            pos = new Vector3(0, 3, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        if (lane == 3 && row == 1) //right lane
        {
            pos = new Vector3(4, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 2)
        {
            pos = new Vector3(4, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 3)
        {
            pos = new Vector3(4, 2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
    }


    void SpawnHealth(int lane, int row)
    {
        Vector3 pos = new Vector3();
        //check 3 positions on each lane
        if (lane == 1 && row == 1) //left lane
        {
            pos = new Vector3(-4, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 2)
        {
            pos = new Vector3(-4, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 3)
        {
            pos = new Vector3(-4, 2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        if (lane == 2 && row == 1) //mid lane
        {
            pos = new Vector3(0, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        } else if(lane == 2 && row == 2)
        {
            pos = new Vector3(0, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        } else if (lane == 2 && row == 3)
        {
            pos = new Vector3(0, 3, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        if (lane == 3 && row == 1) //right lane
        {
            pos = new Vector3(4, -2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 2)
        {
            pos = new Vector3(4, 0, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 3)
        {
            pos = new Vector3(4, 2, 30);
            Instantiate(powerUp, pos, Quaternion.identity);
        }
    }

    void SpawnVertical(int lane, int row)
    {
        Vector3 pos = new Vector3();
        //check 3 positions on each lane
        if (lane == 1 && row == 1) //left lane
        {
            pos = new Vector3(-4, -2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 2)
        {
            pos = new Vector3(-4, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 3)
        {
            pos = new Vector3(-4, 2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        if (lane == 2 && row == 1) //mid lane
        {
            pos = new Vector3(0, -2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        } else if(lane == 2 && row == 2)
        {
            pos = new Vector3(0, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        } else if (lane == 2 && row == 3)
        {
            pos = new Vector3(0, 2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        if (lane == 3 && row == 1) //right lane
        {
            pos = new Vector3(4, -2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 2)
        {
            pos = new Vector3(4, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 3)
        {
            pos = new Vector3(4, 2, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
    }

    
}
