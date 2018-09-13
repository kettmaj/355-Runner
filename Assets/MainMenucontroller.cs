using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenucontroller : MonoBehaviour {

	public void PlaybuttonPressed()
    {
        print("play");
        SceneManager.LoadScene("SampleScene");
    }
    public void OptionsPressed()
    {
        print("options");

    }
    public void QuitPressed()
    {
        print("quit");
        Application.Quit();

    }
}
