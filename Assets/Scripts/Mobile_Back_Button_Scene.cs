using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mobile_Back_Button_Scene : MonoBehaviour {
    public string PrevScene;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync(PrevScene, LoadSceneMode.Single);
            Debug.Log("Button Clicked");
        }
    }
}
