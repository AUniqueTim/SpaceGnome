using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public RotationEngine rotationEngine;

    public float anglePerUpdate = 0;

    [SerializeField] GameObject rotationEngineObject;

    public float revolutionsPerYear;

    public GameObject gravityAnchor;
   
    public GameObject objectRotated;

    Vector3 initialPos;
    Quaternion initialRot;

    void Start()
    {
        rotationEngineObject =  GameObject.Find("RotationEngine"); //returns found GO.
      
        initialPos = gameObject.transform.position - gravityAnchor.transform.position;
        initialRot = gameObject.transform.rotation;
      
    }


    void Update()
    {
        if (gravityAnchor != null)
        {
            gameObject.transform.position = gravityAnchor.transform.position + initialPos;
            gameObject.transform.rotation = initialRot;

            float yearRatio = rotationEngine.totalTime / 31557600;

            gameObject.transform.RotateAround(gravityAnchor.transform.position, new Vector3(0, 1, 0), 360 * revolutionsPerYear * yearRatio); //When axis added (second parameter), rotates AROUND at given angle.
        }

    }
}
