using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotationEngine : MonoBehaviour
{
    public float totalTime = 0;

    public float timeRatio = 1;

  
    void Update()
    {
    }
    public void FixedUpdate()
    {

        totalTime += Time.deltaTime * timeRatio;
    }
}
