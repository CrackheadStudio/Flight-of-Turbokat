using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax; 
}

public class AccelerometerInput : MonoBehaviour {
    public float movementSpeed;
    public Boundary boundary;
    public float tiltz;

    public GameObject missile;
    public Transform missileSpawn; 
    public Transform missileSpawn2;
    public float fireRate;

    private float nextFire;
    
    

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(missile, missileSpawn.position, missileSpawn.rotation);
            Instantiate(missile, missileSpawn2.position, missileSpawn.rotation);
            Debug.Log(missile + "Missiles Fired");
        }
    }
    
    void FixedUpdate() {
        float moveHorizontal = Input.acceleration.x;
        //Input.GetAxis("Horizontal");
        // moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);
        GetComponent<Rigidbody>().velocity = movement * movementSpeed;
        //transform.Translate(Input.acceleration.x*movementSpeed, 0, 0);


        
        GetComponent<Rigidbody>().position = new Vector3
        (
            Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax),
            0.0f,
           0.0f
        );

        GetComponent<Rigidbody>().rotation = Quaternion.Euler(0.0f, 0.0f, GetComponent<Rigidbody>().velocity.x * -tiltz);
    }
}
