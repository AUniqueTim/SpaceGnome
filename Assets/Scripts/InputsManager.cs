using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsManager : MonoBehaviour
{
    public CameraRotation cameraRotation;

    //START SINGLETON


    public static InputsManager instance;
    public static InputsManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<InputsManager>();
                if (instance == null)
                {
                    GameObject singleton = new GameObject();
                    singleton.AddComponent<InputsManager>();
                    singleton.name = "(Singleton)  InputsManager";
                }
            }
            return instance;
        }
    }
    public void Awake()
    {
        instance = this;

    }
    public float MouseX;
    public float MouseY;

    [SerializeField] private float maxXRotation;
    [SerializeField] private float maxYRotation;


    public void OnRotationX(InputAction.CallbackContext Context)
    {
        MouseX = Context.ReadValue<float>();
        if (MouseX >= maxXRotation)
        {
            MouseX = maxXRotation;
        }
    }

    public void OnRotationY(InputAction.CallbackContext Context)
    {
        MouseY = Context.ReadValue<float>();
        if (MouseY >= maxYRotation)
        {
            MouseY = maxYRotation;
        }
    }

    private void Update()
    {
        //OnRotationX(Context);
        //OnRotationY();
    }
}
