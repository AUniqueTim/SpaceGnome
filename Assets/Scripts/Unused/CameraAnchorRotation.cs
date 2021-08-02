using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraAnchorRotation : MonoBehaviour
{
    public CameraAnchorRotation camAnchorControls;

    public Vector3 camAnchorRot;

    public void Awake()
    {
        camAnchorControls = new CameraAnchorRotation();
        //camAnchorControls.Camera.Rotate.performed += ctx => camRot = ctx.ReadValue<Vector2>();
        //camAnchorControls.Camera.Rotate.canceled += ctx => camRot = Vector2.zero;
    }
    }
