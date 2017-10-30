using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit_Button_Script : MonoBehaviour {
    //public Texture2D button;
    public string SceneName;

    public void onClick()
    {
        Application.Quit();
    }

    public void Update()
    {
        Debug.Log(Input.touchCount);
       
    }

    private void OnMouseDown()
    {
        SceneManager.LoadSceneAsync(SceneName, LoadSceneMode.Single);
        Debug.Log("Button Clicked");
    }
}
