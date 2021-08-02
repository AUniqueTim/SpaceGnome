using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotations : MonoBehaviour
{

    [SerializeField] public GameObject rotatedObject;
    [SerializeField] float rotationAngle;
    [SerializeField] Vector3 rotationPoint;
    [SerializeField] GameObject rotationAnchor;

    void FixedUpdate()
    {

        rotatedObject.transform.RotateAround(rotationPoint, rotationAnchor.transform.position, rotationAngle * Time.deltaTime);
    }

}
