using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Scene : MonoBehaviour {
    // Update is called once per frame
   public string Scenename1;
   
   public void Load_Scene()
        {
            SceneManager.LoadSceneAsync(Scenename1, LoadSceneMode.Single);
            Debug.Log("Button Clicked");
        }
    
}
