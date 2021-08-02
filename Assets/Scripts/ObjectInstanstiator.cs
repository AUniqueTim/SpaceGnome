using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ObjectInstanstiator : MonoBehaviour
{
    
    [Header("Game Objects")]
    public GameObject objectInstantiator;   //This game object assigned in Inspector.
    public GameObject[] objects;            //Array of individual objects to be instantiated.
    public GameObject player;               //Player GO.
    private GameObject instantiatedObject;  //Each instance of an individual object instantiated.

    public Transform firePoint;

    public bool instantiatingAllowed;
    private bool objectInstantiated;         //Returns true immedietly after an individual object is instantiated.
    public bool playerCollision = false;    //Used to detect whether or not player object has collided with this instance of an object.

    [Header("Number of Objects Instantiated")]
    public int objectCount;                 //Current number of objects that have been instantiated.
    [Header("Max Objects Allowed")]
    public int maxObjectCount;              //Maximum number of objects that can be instantiated at once.

    [Header("Fire Speed")]
    public int fireSpeed;

    [Header("Random Distance Range From Player")]
    public float xDistanceFromPlayerMin;
    public float xDistanceFromPlayerMax;
    public float yDistanceFromPlayerMin;
    public float yDistanceFromPlayerMax;
    public float zDistanceFromPlayerMin;
    public float zDistanceFromPlayerMax;

    public Transform instantiatedObjectParentTransform;

   Vector3 randomPos;


    private void Awake()
    {
        //instantiatedObject = null;
        objects[0].tag = "Asteroid";
        objects[1].tag = "Asteroid";
        objects[2].tag = "Asteroid";
        objects[3].tag = "Asteroid";
        objects[4].tag = "Asteroid";
        objects[5].tag = "Asteroid";
        objects[6].tag = "Platform";
        objects[7].tag = "Platform";
        objects[8].tag = "Platform";
        objects[9].tag = "Platform";
        objects[10].tag = "Asteroid";
        objects[11].tag = "Asteroid";
        objects[12].tag = "Asteroid";
        objects[13].tag = "Platform";
        objects[14].tag = "Platform";
        objects[15].tag = "Asteroid";
        objects[16].tag = "Platform";
        objects[17].tag = "Asteroid";

     //   StartCoroutine(Wait());

    }
    void Start()
    {
        objectInstantiated = false;
        instantiatingAllowed = true;
        
    }
    void Update()
    {
        if (instantiatingAllowed) { if (playerCollision == true) { InstantiateObject(); } }
        if (objectCount <= maxObjectCount) { instantiatingAllowed = true; }
        else if (objectCount > maxObjectCount) { instantiatingAllowed = false; DestroyImmediate(instantiatedObject); }

        randomPos.x = Random.Range(xDistanceFromPlayerMin, xDistanceFromPlayerMax);
        randomPos.y = Random.Range(yDistanceFromPlayerMin, yDistanceFromPlayerMax);
        randomPos.z = Random.Range(zDistanceFromPlayerMin, zDistanceFromPlayerMax);

        firePoint.position += randomPos;

        objectInstantiator = gameObject;
    }

    void InstantiateObject()
    {
        //gameObject.SetActive(true);
        objectCount += 1;
        Instantiate(instantiatedObject = objects[Random.Range(0,objects.Length)], firePoint.position, firePoint.rotation, instantiatedObjectParentTransform);
        //instantiatedObject.transform.Translate(Vector3.forward * fireSpeed);
        if (instantiatedObject != null) { if (instantiatedObject.activeInHierarchy) { objectInstantiated = true; Debug.Log("Instantaited Object: " + instantiatedObject.name); } }
        else { objectInstantiated = false; }
       
        

       // if (instantiatedObject != null){ instantiatedObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * fireSpeed); }

        playerCollision = false;

        //instantiatedObject.SetActive(true);
        if (instantiatedObjectParentTransform.childCount >= maxObjectCount) { Destroy(instantiatedObjectParentTransform.GetChild(1).gameObject); }
        else { instantiatedObject.SetActive(true);  }
        

    }
    public void OnTriggerEnter(Collider collision) {if (collision.gameObject.tag == "Player")
        { playerCollision = true; }
    }
   
}