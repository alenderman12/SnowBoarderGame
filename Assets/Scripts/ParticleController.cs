using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private ParticleSystem[] particles;

    public void PlayParticle(string particleName)
    {
        for (int i = 0; i < particles.Length; i++)
        {
            if (particleName == particles[i].name)
            {
                particles[i].Play();
                break;
            }
        }
    }
    public void StopParticle(string particleName)
    {
        for (int i = 0; i < particles.Length; i++)
        {
            if (particleName == particles[i].name)
            {
                particles[i].Stop();
                break;
            }
        }
    }
}
