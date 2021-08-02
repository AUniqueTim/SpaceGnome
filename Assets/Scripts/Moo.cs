using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moo : MonoBehaviour
{

    public AudioSource moo;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            moo.Play();
        }
    }
}
