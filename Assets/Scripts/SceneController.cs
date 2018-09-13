using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    // variables for adding walls at random moments
    public GameObject prefabWall;
    public GameObject shortWall;
    float wallChoice = 0;
    float delayUntilSpawn = 0;
    float whichLane = 0;
    int whichRow = 0;
    Vector3 spawn = new Vector3();
    //idea: have each lane have a countdown for spawning, and a % chance of spawning in one of the 3 rows
    float delayLeftLane = 0;
    float delayMidLane = 0;
    float delayRightLane = 0;
    //idea, give the player a "blast" that uses up ammo/fuel to break a wall to make up for the possibility of a 9 point spawn



    /* variables for spawning tracks in succession
    public Track[] prefabTracks;
    List<Track> tracks = new List<Track>();
    */

    void Start () {
        //SpawnTrack();
	}
	
	// Update is called once per frame
	void Update () {
        delayLeftLane -= Time.deltaTime;
        delayMidLane -= Time.deltaTime;
        delayRightLane -= Time.deltaTime;
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

        
    }

    void SpawnHealth(int lane, int row)
    {

    }

    void SpawnVertical(int lane, int row)
    {
        Vector3 pos = new Vector3();
        //check 3 positions on each lane
        if (lane == 1 && row == 1) //left lane
        {
            pos = new Vector3(-4, -3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 2)
        {
            pos = new Vector3(-4, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 1 && row == 3)
        {
            pos = new Vector3(-4, 3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        if (lane == 2 && row == 1) //mid lane
        {
            pos = new Vector3(0, -3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        } else if(lane == 2 && row == 2)
        {
            pos = new Vector3(0, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        } else if (lane == 2 && row == 3)
        {
            pos = new Vector3(0, 3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        if (lane == 3 && row == 1) //right lane
        {
            pos = new Vector3(4, -3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 2)
        {
            pos = new Vector3(4, 0, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
        else if (lane == 3 && row == 3)
        {
            pos = new Vector3(4, 3, 30);
            Instantiate(prefabWall, pos, Quaternion.identity);
        }
    }

    
}
