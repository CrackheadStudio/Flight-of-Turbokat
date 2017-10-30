using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_01 : MonoBehaviour {

    public GameObject mainProjectile;
    public ParticleSystem mainParticleSystem;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            mainProjectile.SetActive(true);
        }

        if (mainParticleSystem.IsAlive() == false)
            mainProjectile.SetActive(false);
	}
}
