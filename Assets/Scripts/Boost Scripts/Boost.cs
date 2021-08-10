using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public PlayerManager playerManagerScript;
    public GameObject boostBarGO;
    //public float boost = playerManagerScript.boost;

    //public GameObject fireworksObject;
    //public ParticleSystem boostExplosionParticles;

    public GameObject player;
    private void Awake()
    {
        
        
        boostBarGO = FindObjectOfType<BoostBar>().gameObject;
        DontDestroyOnLoad(boostBarGO);
        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(FindObjectOfType<Boost>().gameObject);
    }
    private void OnCollisionEnter(Collision collider)
    {
        if (collider.gameObject.tag == "Player")
        {
           // PlayerManager.boost += 1000f;
            //Points.boost += 1000f;
            //Debug.Log("+1000 Boost.");
            //Points.points += 1000f;
            //Debug.Log("+1000 Points.");
            //GnomeMovement.isIdle = true;
            //fireworksObject.SetActive(true);

            //if (collider.gameObject.tag == "HealthPowerUp")
            //{
            //    PlayerHealth.currentHealth += 1f;
            //    Debug.Log("Gained 1 Heatlh.");
            //}

            //Destroy(gameObject);
        }
    }
}
