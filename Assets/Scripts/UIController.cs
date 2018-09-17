using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SceneController))]
public class UIController : MonoBehaviour {

    public Text scoreText;
    public Slider fuelSlider;
    public PlayerMovement playerRef;
    


    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Fuel: " + playerRef.ammo;
        fuelSlider.value = playerRef.ammo;
        
        
	}

    public void SliderValuechanged()
        {

    }
}
