using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : Powerup
{

    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }

    public override void PickedUpPowerUp()
    {
        objectRenderer.enabled = false;
        powerParticleSystem.gameObject.SetActive(true);
    }
}
