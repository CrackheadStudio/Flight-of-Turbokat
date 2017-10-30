using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Switch : MonoBehaviour {

    public Camera DeactivateCamera, ActivateCamera;
    public Transform DeactivateCanvas, ActivateCanvas;
    //public bool camSwitch;
	// Use this for initialization
	
    public void SwitchCam()
    {
        //camSwitch = !camSwitch;
        DeactivateCamera.gameObject.SetActive(false);
        ActivateCamera.gameObject.SetActive(true);
        DeactivateCanvas.gameObject.SetActive(false);
        ActivateCanvas.gameObject.SetActive(true);
    }
}
