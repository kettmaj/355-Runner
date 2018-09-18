using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

    const float speed = 30;
    const float ZKILL = 20;
    public AudioClip wallHit;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position += new Vector3(0, 0, speed) * Time.deltaTime;
        if (transform.position.z > ZKILL)
        {
            Destroy(gameObject);
        }
    }

    void OverlappingAABB(AABB other)
    {
               
        if (other.tag == "Wall") ///What happens when the player hits a wall
        {
            //GetComponent<AudioSource>().clip = wallHit;
            GetComponent<AudioSource>().PlayOneShot(wallHit);

            Destroy(other.gameObject);
        }
    }
}
