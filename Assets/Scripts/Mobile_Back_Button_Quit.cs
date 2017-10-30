using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile_Back_Button_Quit : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
