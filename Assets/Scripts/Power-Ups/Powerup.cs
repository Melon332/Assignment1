using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    [HideInInspector] public MeshRenderer objectRenderer;
    [HideInInspector] public ParticleSystem powerParticleSystem;
    public abstract void PickedUpPowerUp();

    public virtual void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        powerParticleSystem = GetComponentInChildren<ParticleSystem>();
        powerParticleSystem.gameObject.SetActive(false);
    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PickedUpPowerUp();
        }
    }
}
