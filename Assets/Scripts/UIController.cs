using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(SceneController))]
public class UIController : MonoBehaviour {

    public Text scoreText;
    public Slider fuelSlider;
    SceneController scene;

    
	void Start () {
        scene = GetComponent<SceneController>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Fuel: " + scene.fuel;
        fuelSlider.value = scene.fuel;
        //fuelSlider = scene.fuel;
        
	}

    public void SliderValuechanged()
        {

    }
}
