using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSystemsPlayback : MonoBehaviour
{
    public PlayerManager playerManager;
    [SerializeField] ParticleSystem dust;
    [SerializeField] ParticleSystem coin;
    [SerializeField] ParticleSystem coin2;
    [SerializeField] ParticleSystem coin3;

    private void Awake()
    {
       // dust = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if (playerManager.isDustExplosion == true)
        {
            dust.Play();
        }
        if (playerManager.isCoinPickUp1 == true)
        {
            coin.Play();
        }
        if (playerManager.isCoinPickUp2 == true)
        {
            coin2.Play();
        }
        if (playerManager.isCoinPickUp3 == true)
        {
            coin3.Play();
        }
    }
}
