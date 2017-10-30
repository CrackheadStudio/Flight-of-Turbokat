using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : PauseCam {
    
    public void QuitButton(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
    }

    public void ResumeButton()
    {
        
        Debug.Log("Pause value is:" + Pause);
        PauseGame(true, false);
        Pause = false;
        camSwitch = true;
        
    }

	public void PauseButton()
	{
		Debug.Log("Pause Button Clicked");
		PauseGame(false,true);
		Pause = true;
		camSwitch = false;
	}
}
