using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu_Quit_Button : MonoBehaviour {

	public void TapQuit(string SceneName)
    {
        SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
    }
}
