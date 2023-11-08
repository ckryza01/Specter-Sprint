using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbController : MonoBehaviour
{
    private ParticleSystem mistParticleSystem;

    private void Start()
    {
        mistParticleSystem = GetComponent<ParticleSystem>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CollectOrb();
        }
    }

    void CollectOrb()
    {
        OrbCounter orbCounter = FindObjectOfType<OrbCounter>();
        if (orbCounter != null)
        {
            orbCounter.IncrementOrbCount();
        }
        Destroy(gameObject);
    }
}
