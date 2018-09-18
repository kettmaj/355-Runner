using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenucontroller : MonoBehaviour {

    public AudioSource Beep = null;

	public void PlaybuttonPressed()
    {
        //print("play");
        //Beep.Play;
        SceneManager.LoadScene("SampleScene");

    }
    public void OptionsPressed()
    {
        //print("options");

    }
    public void QuitPressed()
    {
        //print("quit");
        Application.Quit();

    }
}
