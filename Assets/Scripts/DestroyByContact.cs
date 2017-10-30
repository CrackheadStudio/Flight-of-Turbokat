using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
    public GameObject explosion;
    public int scoreValue;
    private GameController gameController;

    void Start()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' script");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Boundary")
        {
            Debug.Log("function returned");
            return;
        }
        Debug.Log(other.name);
        Debug.Log(explosion.name);
        gameController.AddScore(scoreValue);
        Instantiate(explosion, transform.position, transform.rotation);
        Debug.Log("function called");
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
