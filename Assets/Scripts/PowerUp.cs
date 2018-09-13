using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour {


    const float speed = -10;
    const float ZKILL = -10;

    public enum PowerupType //powerup.type
    {
        none,
        Health,
        Ammo
    }
    public PowerupType type;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        if (transform.position.z < ZKILL)
        {
            Destroy(gameObject);
        }
    }
}
