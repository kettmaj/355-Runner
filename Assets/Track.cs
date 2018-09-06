using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Track : MonoBehaviour {

    public Transform pointIn;
    public Transform pointOut;

    public Transform[] wallSpawnPoints;

    public GameObject prefabWall;

    void Start()
        {
        if (wallSpawnPoints.Length == 0) return;
        if (!prefabWall) return;

        //get a randon position
        int randIndex = Random.Range(0, wallSpawnPoints.Length);
        Vector3 spawnPos = wallSpawnPoints[randIndex].position;


        //spawn a wall, parent it to this chuck of track
        Instantiate(prefabWall, spawnPos, Quaternion.identity, transform);
    }
}
