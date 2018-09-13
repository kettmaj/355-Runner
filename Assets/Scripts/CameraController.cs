using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public Transform viewTarget;
    public int cameraMult = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if(viewTarget)
        {

            transform.position = Vector3.Lerp(transform.position, viewTarget.position, Time.deltaTime * cameraMult);
        }
		
	}
}
