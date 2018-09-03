using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    const float GRAVITY = -9.8f;
    public float laneWidth = 2;
    public int jumpHeight = 2;
    int lane = 0;
    int height = 0;
    float jumpCooldown = 0;
    Vector3 velocity;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        jumpCooldown -= Time.deltaTime;

        float h = Input.GetAxisRaw("Horizontal"); //code for sliding between lanes
        if (Input.GetButtonDown("Horizontal"))
        {
            if (h == -1) // if pressing left
            {
                lane--;
            }
            else if (h == 1) // if pressing right
            {
                lane++;
            }
            lane = Mathf.Clamp(lane, -1, 1);
        }

        float targetX = lane * laneWidth;

        float x = (targetX - transform.position.x) * .1f;
        transform.position += new Vector3(x, 0, 0);

        float s = Input.GetAxisRaw("Jump");  // code for jumping
        if (Input.GetButtonDown("Jump"))
        {
            if (jumpCooldown <= 0)
            {
                if (s == 1) // if pressing space
                {
                    height++;
                }
                height = Mathf.Clamp(height, 0, 1);
                jumpCooldown = 2;
            }
        }

        float targetY = height * jumpHeight;

        float y = (targetY - transform.position.y) * .1f; //slide vs instant
        transform.position += new Vector3(0, y, 0);


        if (transform.position.y >= 0)  //code for falling if having jumped
        {
            velocity += new Vector3(0, GRAVITY, 0) * Time.deltaTime;
            transform.position += velocity * Time.deltaTime;
        }
        print(y);
    }
}
