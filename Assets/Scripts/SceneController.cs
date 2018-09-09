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

        /*
         //code for spawing walls at random moments
        wallChoice = Random.Range(0, 2);

        delayUntilSpawn -= Time.deltaTime;
        if (delayUntilSpawn <= 0)
        {
            SpawnVertical(spawn, 2, 3);


            whichLane = Random.Range(1, 4);
            if (whichLane == 1)
            {
                                
                    Vector3 pos = new Vector3(-4, 0, 20);
                    if (wallChoice == 0)
                    {
                        Instantiate(prefabWall, pos, Quaternion.identity);
                    } else if (wallChoice == 1)
                    {
                        Instantiate(shortWall, pos, Quaternion.identity);
                    }
                    delayUntilSpawn = Random.Range(1, 2);
            } else if (whichLane == 2)
            {
                    Vector3 pos = new Vector3(0, 0, 20);
                    if (wallChoice == 0)
                    {
                        Instantiate(prefabWall, pos, Quaternion.identity);
                    }
                    else if (wallChoice == 1)
                    {
                        Instantiate(shortWall, pos, Quaternion.identity);
                    }
                    delayUntilSpawn = Random.Range(1, 3);
            } else if (whichLane == 3)
            {
                    Vector3 pos = new Vector3(4, 0, 20);
                    if (wallChoice == 0)
                    {
                        Instantiate(prefabWall, pos, Quaternion.identity);
                    }
                    else if (wallChoice == 1)
                    {
                        Instantiate(shortWall, pos, Quaternion.identity);
                    }
                    delayUntilSpawn = Random.Range(1, 3);
            }
        }
        */
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

    /* // spawning tracks in succession
    void SpawnTrack()
    {
        while (tracks.Count < 5)
        {

            Vector3 ptOut = new Vector3(0 -7, 0);
            if(tracks.Count > 0) ptOut = tracks[tracks.Count - 1].pointOut.position;


            Track prefab = prefabTracks[Random.Range(0, prefabTracks.Length)];

            Vector3 ptIn = prefab.pointIn.position;
            Vector3 pos = (prefab.transform.position - ptIn) + ptOut; //finding distance from middle point to in point, then adding the out point to that

            Track newTrack = Instantiate(prefab, pos, Quaternion.identity);
            tracks.Add(newTrack);
        }
    }
    */
}
