using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;

public class CameraRotation : MonoBehaviour
{
    public SpaceGnome_02_InputActions camControls;
public SpaceGnome_02_InputActions playerControls;
    public PlayerMovement m_playerMovement;

    Vector3 playerRot;
    public Vector3 camRot;
    //Vector3 camXRot;

    //[SerializeField] private float maxXRot;
   // [SerializeField] private float maxYRot;
    [SerializeField] private float playerRotationSpeed;
    [SerializeField] private float camRotationSpeed;
    public float camSpeed;
    
    public GameObject player;
    public GameObject cam;
    Vector2 camYRot;

    public void Awake()
    {
        camControls = new SpaceGnome_02_InputActions();
        playerControls = new SpaceGnome_02_InputActions();

     //   camControls.Camera.RotateCamera.performed += ctx => camRot = ctx.ReadValue<Vector2>();
     //   camControls.Camera.RotateCamera.canceled += ctx => camRot = Vector2.zero;
       playerControls.Player.Rotate.performed += ctx => playerRot = ctx.ReadValue<Vector2>();
        playerControls.Player.Rotate.canceled += ctx => playerRot = Vector2.zero;
     
    }
   
    private void Update()
    {
        
       
        if (playerControls.Player.MoveNegativeX.triggered || playerControls.Player.MoveNegativeY.triggered
                || playerControls.Player.MoveX.triggered || playerControls.Player.MoveY.triggered)
        {
            Vector3 playerRotation = new Vector3(playerRot.y, playerRot.x, playerRot.z);
            player.transform.Rotate(-playerRotation, Space.Self);
        }

       else if (!playerControls.Player.MoveNegativeX.triggered && !playerControls.Player.MoveNegativeY.triggered
                 && !playerControls.Player.MoveX.triggered && !playerControls.Player.MoveY.triggered /*&& camControls.Camera.Rotate.triggered*/)
        {
            Vector3 cameraRotation = new Vector3(camRot.y, camRot.x, camRot.z);
            transform.Rotate(cameraRotation, Space.World);

            //Vector3 cameraRotation = new Vector3(camRot.y, camRot.x, camRot.z);
           // transform.Rotate(player.transform.position, cameraRotation.y * camSpeed * camRotationSpeed * Time.deltaTime, Space.World);
           // transform.Rotate(player.transform.position, cameraRotation.x * camSpeed * camRotationSpeed * Time.deltaTime, Space.World);
        }
        else if (playerControls.Player.MoveNegativeX.triggered || playerControls.Player.MoveNegativeY.triggered
                 || playerControls.Player.MoveX.triggered || playerControls.Player.MoveY.triggered /*&& camControls.Camera.Rotate.triggered*/)
        {
            Vector3 playerRotation = new Vector3(playerRot.y, playerRot.x, playerRot.z);
            //transform.Rotate(playerRotation  * camSpeed * Time.deltaTime, Space.Self);
            player.transform.Rotate(-playerRotation * playerRotationSpeed * Time.deltaTime, Space.Self);

            Vector3 camRotation = new Vector3(camRot.y, camRot.x, camRot.z);
            transform.Rotate(camRotation * camSpeed * camRotationSpeed * Time.deltaTime, Space.World);
        }


        //Vector3 playerRotation = new Vector3(playerRot.x, playerRot.y, playerRot.z);






        //if (playerControls.Player.Rotate.triggered)
        //{

        //}
        ////if (playerControls.Player.Rotate.triggered && camControls.Camera.RotateCamera.triggered)
        ////{
        ////    Vector3 playerRotation = new Vector3(playerRot.x, playerRot.y, playerRot.z);
        ////    player.transform.Rotate(playerRotation * playerRotationSpeed *  Time.deltaTime, Space.World);

        //// //   transform.Rotate(transform.position, -camRotation.x * camSpeed * camRotationSpeed * playerRotationSpeed * Time.deltaTime, Space.World);
        //// //   transform.Rotate(transform.position, -camRotation.z * camSpeed * camRotationSpeed * playerRotationSpeed * Time.deltaTime, Space.World);
        ////}
        //else if (!playerControls.Player.Rotate.triggered && camControls.Camera.RotateCamera.triggered)
        //{
        //    Vector3 camRotation = new Vector3(camRot.y, camRot.x, camRot.z);
        //    player.transform.Rotate(camRotation * camSpeed * camRotationSpeed * playerRotationSpeed * Time.deltaTime);
        //    transform.Rotate(camRotation * camSpeed * camRotationSpeed * Time.deltaTime);
        //    // transform.Rotate(transform.position, -camRotation.x * camSpeed * camRotationSpeed * playerRotationSpeed * Time.deltaTime, Space.World);
        //    // transform.Rotate(transform.position, -camRotation.z * camSpeed * camRotationSpeed * playerRotationSpeed * Time.deltaTime, Space.World);
        //}

        ////if (playerControls.Player.Rotate.triggered && !camControls.Camera.RotateCamera.triggered)
        ////{
        ////    Vector3 playerRotation = new Vector3(playerRot.x, playerRot.y, playerRot.z);
        ////    player.transform.Rotate(playerRotation * playerRotationSpeed * Time.deltaTime, Space.World);
        ////   //Vector3 camRotation = new Vector3(camRot.y, camRot.x, camRot.z);
        ////   // transform.Rotate(transform.position, camRotation.x * camSpeed * camRotationSpeed * Time.deltaTime, Space.World);

        ////}

    }

    public  void OnEnable()
    {
        camControls.Camera.Enable();
        playerControls.Player.Enable();
    }
   public void OnDisable()
    {
        camControls.Camera.Disable();
        playerControls.Player.Enable();
    }
}
