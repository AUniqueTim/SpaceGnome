using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

using Cinemachine;
[RequireComponent(typeof(PlayerInput))]
public class CameraController : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject frontCamera;
    public GameObject sideCamera;

    public SpaceGnome_02_InputActions camControls;
   // public SpaceGnome_02_InputActions playerControls;
    public PlayerMovement m_playerMovement;

    //public float playerRotationSpeed;
    //public float camRotationSpeed;
    //public float camSpeed;

    private float playerSpeed;

  
    public Vector2 _move;
    public Vector2 _look;

    public GameObject followTransform;

    public Quaternion nextRotation;
    public Vector3 nextPosition;
    public float rotationPower = 3f;
    public float rotationLerp = 0.5f;
    
    public GameObject camera;
    public Camera cam;
    [SerializeField] CinemachineVirtualCamera vCam1;
    [SerializeField] CinemachineVirtualCamera vCam2;

    //public Recentering(bool recenter, float waitTime, float recenteringTime)
    //{

    //}


    private void Awake()
    {
       
        playerSpeed = m_playerMovement.playerSpeed;
       // playerControls = new SpaceGnome_02_InputActions();
        camControls = new SpaceGnome_02_InputActions();

        camControls.Camera.ChangeCamera.performed += ctx => SwitchCamera();

        // camControls.Camera.RotateCamera.performed += ctx => camRot = ctx.ReadValue<Vector2>();
        // camControls.Camera.RotateCamera.canceled += ctx => camRot = Vector3.zero;

        //  playerControls.Player.Rotate.performed += ctx => playerRot = ctx.ReadValue<Vector2>();
        //   playerControls.Player.Rotate.canceled += ctx => playerRot = Vector2.zero;

    }


    private void Update()
    {

       // if (cam.gameObject.transform.rotation.x > 45) { cam.gameObject.transform.Rotate(-10,0,0); }
        //if (m_playerMovement.transform.position != null) { vCam1.transform.LookAt(new Vector3(m_playerMovement.transform.position.x, m_playerMovement.transform.position.y, m_playerMovement.transform.position.z)); }
        //else { vCam1 = vCam2; }
       // camera.LookAtTargetPosition(transform.position);

        //if (!vCam1.gameObject.activeInHierarchy)
        //{
        //    vCam1.FollowTargetAttachment = vCam2.FollowTargetAttachment;
        //    vCam1.LookAtTargetAttachment = vCam2.follow
        //}

        _move = new Vector3(m_playerMovement.playerRotation.x, m_playerMovement.playerRotation.y, m_playerMovement.playerRotation.z);
        _look = new Vector3(m_playerMovement.playerRotation.x, m_playerMovement.playerRotation.y, m_playerMovement.playerRotation.z);

        ////------------NEW CODE START
        #region Player Based Rotation

        //Move the player based on the X input on the controller
        //transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);

        #endregion

        #region Follow Transform Rotation

        //Rotate the Follow Target transform based on the input
        if (followTransform != null)
        {
            followTransform.transform.rotation *= Quaternion.AngleAxis(_look.x * rotationPower, Vector3.up);
        }

        

        #endregion

        #region Vertical Rotation
        followTransform.transform.rotation *= Quaternion.AngleAxis(_look.y * rotationPower, Vector3.right);

        var angles = followTransform.transform.localEulerAngles;
        angles.z = 0;

        var angle = followTransform.transform.localEulerAngles.x;

        //Clamp the Up/Down rotation
        if (angle > 180 && angle < 360)
        {
            angles.x = 360;
        }
        else if (angle < 180 && angle > 55)
        {
            angles.x = 55;
        }


        followTransform.transform.localEulerAngles = angles;
        #endregion


        nextRotation = Quaternion.Lerp(followTransform.transform.rotation, nextRotation, Time.deltaTime * rotationLerp);

        if (m_playerMovement.moveX.x == 0
            && m_playerMovement.moveX.y == 0
            && m_playerMovement.moveY.x == 0
            && m_playerMovement.moveY.y == 0
            && m_playerMovement.negMoveX.x == 0
            && m_playerMovement.negMoveX.y == 0
            && m_playerMovement.negMoveY.x == 0
            && m_playerMovement.negMoveY.y == 0)
        {
            nextPosition = transform.position;

            if (m_playerMovement.moveX.z > 0)
            {
                //Set the player rotation based on the look transform
                transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
                //reset the y rotation of the look transform
                followTransform.transform.localEulerAngles = new Vector3(angles.x, 0, 0);
            }

            return;
        }
        float moveSpeed = playerSpeed/* / 100f*/;
        Vector3 position = (transform.forward * _move.y * moveSpeed) + (transform.right * _move.x * moveSpeed);
        nextPosition = transform.position + position;


        //Set the player rotation based on the look transform
        transform.rotation = Quaternion.Euler(0, followTransform.transform.rotation.eulerAngles.y, 0);
        //reset the y rotation of the look transform
        followTransform.transform.localEulerAngles = new Vector3(angles.x, 0, 0);

        if (camControls.Camera.ChangeCamera.triggered)
        {
            SwitchCamera();
        }
    }
    
    public void SwitchCamera()
    {
        if (sideCamera.activeInHierarchy)
            {
                mainCamera.SetActive(true);
                sideCamera.SetActive(false);
            }

        else if (frontCamera.activeInHierarchy)
            {
                sideCamera.SetActive(true);
                frontCamera.SetActive(false);
            }

        else if (mainCamera.activeInHierarchy)
            {
                frontCamera.SetActive(true);
                mainCamera.SetActive(false);
            }

    }
    public void OnEnable()
    {
        camControls.Camera.Enable();
    }
    public void OnDisable()
    {
        camControls.Camera.Disable();
    }
}
