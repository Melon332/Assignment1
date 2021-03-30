using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Powerup : MonoBehaviour
{
    [HideInInspector] public MeshRenderer objectRenderer;
    [HideInInspector] public ParticleSystem powerParticleSystem;
    [HideInInspector] public GameObject cameraEffect;

    [SerializeField] float timePassedEffect = 3f;

    bool hasActivatedEffect = false;
    
    public abstract void PickedUpPowerUp();

    public virtual void Start()
    {
        objectRenderer = GetComponent<MeshRenderer>();
        powerParticleSystem = GetComponentInChildren<ParticleSystem>();
        powerParticleSystem.gameObject.SetActive(false);
        if(cameraEffect == null)
        {
            StartCoroutine(referenceEffect());
        }
        else
        {
            Debug.Log("Effect has not been found");
            return;
        }

    }
    public virtual void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasActivatedEffect)
        {
            PickedUpPowerUp();
            StartCoroutine(showEffect());
        }
    }

    IEnumerator showEffect()
    {
        cameraEffect.SetActive(true);
        hasActivatedEffect = true;
        yield return new WaitForSeconds(timePassedEffect);
        hasActivatedEffect = false;
        cameraEffect.SetActive(false);
        Destroy(gameObject);
    }
    IEnumerator referenceEffect()
    {
        cameraEffect = GameObject.Find("MinimapEffect");
        Debug.Log("Effect has been found");
        yield return new WaitForSeconds(0.1f);
        cameraEffect.SetActive(false);
    }
}
