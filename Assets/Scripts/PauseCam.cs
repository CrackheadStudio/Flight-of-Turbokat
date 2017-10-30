using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCam : MonoBehaviour {
    // Update is called once per frame
    public Camera GameCam, PauseCa;

    public bool camSwitch;
    public bool Pause;
    public Transform Menu;
    private int i = 1;

	void Update () {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame(Pause, camSwitch);
            Pause = !Pause;
            camSwitch = !camSwitch;
        }
    }

    public void PauseGame(bool State, bool Switch)
    {
            Debug.Log(i++ + " PauseGame function called.");
            Switch = !Switch;
            GameCam.gameObject.SetActive(Switch);
            PauseCa.gameObject.SetActive(!Switch);
            Menu.gameObject.SetActive(!Switch);
            ZeroTimeScale(State);
        
        
    }

    void ZeroTimeScale(bool State)
    {
        Debug.Log(i++ + "ZeroTimeScale function called.");
        State = !State;
        Debug.Log(i++ + "Pause value is: " + State);
        if (State == false)
        {
            Time.timeScale = 1;
            Debug.Log(i++ + "TimeScale set to 1.");
            
        }

        else
        {
            Time.timeScale = 0;
            Debug.Log(i++ + "TimeScale set to 0.");
            
        }
       
    }
}
