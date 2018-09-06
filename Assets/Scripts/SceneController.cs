using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour {
    // variables for adding walls at random moments
    public GameObject prefabWall;
    public GameObject shortWall;
    float wallChoice = 0;
    float delayUntilSpawn = 0;
    bool wallRight = false;
    bool wallMid = false;
    bool wallLeft = false;
    float whichLane = 0;
    
    /* variables for spawning tracks in succession
    public Track[] prefabTracks;
    List<Track> tracks = new List<Track>();
    */

	void Start () {
        //SpawnTrack();
	}
	
	// Update is called once per frame
	void Update () {


        

         //code for spawing walls at random moments
        wallChoice = Random.Range(0, 2);

        delayUntilSpawn -= Time.deltaTime;
        if (delayUntilSpawn <= 0)
        {
            whichLane = Random.Range(1, 4);
            if (whichLane == 1)
            {
                if (wallLeft == false)
                {
                    wallMid = false;
                    wallLeft = true;
                    wallRight = false;
                    Vector3 pos = new Vector3(-4, 0, 20);
                    if (wallChoice == 0)
                    {
                        Instantiate(prefabWall, pos, Quaternion.identity);
                    } else if (wallChoice == 1)
                    {
                        Instantiate(shortWall, pos, Quaternion.identity);
                    }
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
                
            } else if (whichLane == 3)
            {
                if(wallRight == false)
                {
                    wallMid = false;
                    wallLeft = false;
                    wallRight = true;
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
