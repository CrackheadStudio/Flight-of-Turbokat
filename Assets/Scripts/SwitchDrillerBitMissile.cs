using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDrillerBitMissile : MonoBehaviour
{
    

    public void ActivateDriller(GameObject missile1)
    {
        Debug.Log(missile1);
        GameObject button = GameObject.Find("Driller Bit Missile Button");
        Debug.Log(button);
        AccelerometerInput newScript = button.GetComponent<AccelerometerInput>();
        newScript.missile = missile1;
        Debug.Log(newScript.missile);
    }
}
