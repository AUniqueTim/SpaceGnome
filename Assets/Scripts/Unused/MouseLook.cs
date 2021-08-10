using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLook : MonoBehaviour
{
    public SpaceGnome_02_InputActions controls;

    public InputsManager m_InputsManager;

    public Camera camera;

     Vector3 look;

    [SerializeField] private float mouseSensitivity;

    public void Awake()
    {
        controls = new SpaceGnome_02_InputActions();

        //controls.Player.RotationX.performed += context => look = context.ReadValue<Vector2>(); 
        //controls.Player.RotationY.performed += context => look = context.ReadValue<Vector2>();

        //    //  controls.Player.RotationY.performed += context => MouseMove();

        //controls.Player.RotationX.canceled += context => look = Vector2.zero;
        //controls.Player.RotationY.canceled += context => look = Vector2.zero;


    }
    public void MouseMove()
    {

        Vector2 l = new Vector2(-look.x, look.y);
        transform.Rotate(l);



    }

    private void Update()
    {


        Vector2 l = new Vector2(InputsManager.Instance.MouseY, -InputsManager.Instance.MouseX);
        transform.Rotate ( l * mouseSensitivity *Time.deltaTime, Space.World);


    }
    public void OnEnable()
    {
        controls.Player.Enable();
    }
    public void OnDisable()
    {
        controls.Player.Disable();
    }
}