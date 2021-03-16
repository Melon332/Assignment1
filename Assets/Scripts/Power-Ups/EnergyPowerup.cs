using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyPowerup : Powerup
{

    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
    }
    public override void PickedUpPowerUp()
    {
        objectRenderer.enabled = false;
    }
    public override void OnTriggerEnter(Collider other)
    {
        base.OnTriggerEnter(other);
    }
}
