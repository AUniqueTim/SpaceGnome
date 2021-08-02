using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStraightener : MonoBehaviour
{
    [SerializeField] GameObject playerToBeStraightened;

   [System.Obsolete]
   public void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            playerToBeStraightened.transform.rotation.SetEulerRotation(0, 0, 0);
        }
    }
}
