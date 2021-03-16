using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    [HideInInspector] public MeshRenderer objectRenderer;
    public abstract void PickedUpPowerUp();

    public virtual void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>(); 
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickedUpPowerUp();
        }
    }
}
