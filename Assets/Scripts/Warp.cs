using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    [SerializeField] Vector3 originalPos;
    [SerializeField] GameObject player;
    [SerializeField] float minX, maxX, minY, maxY, minZ, maxZ;
   
    private void Update()
    {
        originalPos.x = Random.Range(minX, maxX);
        originalPos.y = Random.Range(minY, maxY);
        originalPos.z = Random.Range(minZ, maxZ);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (player != null)
        {
            if (collision.gameObject.tag == "Player")
            {
                player.transform.position = originalPos;
               // player.transform.Translate(transform.positionoriginalPos);
                
                
            }
        }
        
    }
}
