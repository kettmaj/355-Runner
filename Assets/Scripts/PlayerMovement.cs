using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour {

    const float GRAVITY = -9.8f;
    public float laneWidth = 2;
    public float rowHeight = 2;
    int lane = 0;
    int row = 0;
    public int playerHP = 3;
    public float ammo = 0;
    Vector3 velocity;
    SceneController scene;
    

    void Start () {
        scene = GetComponent<SceneController>();
        ammo = 1000;
    }
	
	// Update is called once per frame
	void Update () {
        ammo -= 1;
        if (playerHP == 0)
        {
            SceneManager.LoadScene("Endscreen");
        }


        float h = Input.GetAxisRaw("Horizontal"); //code for sliding between lanes horizontally
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


        float r = Input.GetAxisRaw("Vertical"); //code for sliding between rows vertically
        if (Input.GetButtonDown("Vertical"))
        {
            if (r == -1) // if pressing left
            {
                row--;
            }
            else if (r == 1) // if pressing right
            {
                row++;
            }
            row = Mathf.Clamp(row, -1, 1);
        }

        float targetY = row * rowHeight;
        float y = (targetY - transform.position.y) * .1f;
        transform.position += new Vector3(0, y, 0);


        /*//jumpin code courtesy of Nick P which will no longer be used
        

        float s = Input.GetAxisRaw("Jump");  // code for jumping        
                                             // Apply GRAVITY:
        velocity += new Vector3(0, GRAVITY, 0) * Time.deltaTime;

        if (Input.GetButtonDown("Jump")) // if "jump" is pressed...
        {
            if (transform.position.y <= 0) // and we're on the ground...
            {
                velocity.y = 6; // go up!
            }
        }
        // Euler integration of physics:
        transform.position += velocity * Time.deltaTime;
        if (transform.position.y < 0) // if on the ground:
        {
            Vector3 pos = transform.position; // copy the position
            pos.y = 0; // clamp y value
            transform.position = pos;
        }
        */
    }

    void OverlappingAABB(AABB other)
    {
         //checking for other component powerup component (if null then not a powerup)
        if (other.tag == "PowerUp")
        {
            PowerUp powerup = other.GetComponent<PowerUp>();
            switch (powerup.type)
            {
                case PowerUp.PowerupType.none:
                    break;
                case PowerUp.PowerupType.Health:
                    if (playerHP < 3)
                    {
                        playerHP++;
                    }
                    break;
                case PowerUp.PowerupType.Ammo:
                    ammo += 100;
                    break;
            }
            Destroy(other.gameObject);
        } else if (other.tag == "Wall") ///What happens when the player hits a wall
        {
            playerHP -= 1;
            Destroy(other.gameObject);
        }
    }
}
