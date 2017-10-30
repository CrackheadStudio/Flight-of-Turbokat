using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_Menu_Resume_Btn : MonoBehaviour {
    public Camera GameCam, PauseCa;

    public bool camSwitch = false;
    
    public void TapResume()
    {
        Time.timeScale = 1;
        camSwitch = !camSwitch;
        GameCam.gameObject.SetActive(camSwitch);
        PauseCa.gameObject.SetActive(!camSwitch);
    }
}
