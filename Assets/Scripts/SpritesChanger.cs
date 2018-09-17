using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SpritesChanger : MonoBehaviour {


    public Sprite hp1, hp2, hp3;
    public PlayerMovement playerRef;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(playerRef.playerHP == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = hp3;
        }
        if(playerRef.playerHP == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = hp2;
        }
        if(playerRef.playerHP == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = hp1;
        }
    }
}
