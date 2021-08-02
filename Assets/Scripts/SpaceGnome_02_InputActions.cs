// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/SpaceGnome_02_InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @SpaceGnome_02_InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @SpaceGnome_02_InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""SpaceGnome_02_InputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""5be4d330-d648-41de-885a-bbf52c507c05"",
            ""actions"": [
                {
                    ""name"": ""MoveX"",
                    ""type"": ""Value"",
                    ""id"": ""0e4e6c02-0a72-4cb3-a40d-c07bc3d023be"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveNegativeX"",
                    ""type"": ""Value"",
                    ""id"": ""2d4c2d86-ceb0-4272-92d4-15e4a9d2424c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveY"",
                    ""type"": ""Value"",
                    ""id"": ""02fc52f7-06b1-4583-9e00-2da524005eb4"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveNegativeY"",
                    ""type"": ""Value"",
                    ""id"": ""f76f0f9b-7f24-455d-a17e-b075f2df09e0"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""33305ec5-62ad-4d32-8a95-3170a14f24c4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""17bfaee9-f283-4c0f-b176-a2f823e535bc"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateLeft"",
                    ""type"": ""Button"",
                    ""id"": ""0452615e-6a86-4c40-b81f-1e7e491fbfdf"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RotateRight"",
                    ""type"": ""Button"",
                    ""id"": ""3cf7d5a3-4a23-4cf3-8614-3d9285c173e7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Float"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c1ba6708-fdcc-480b-93df-43b70cf40098"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""NoseDive"",
                    ""type"": ""PassThrough"",
                    ""id"": ""96d2d732-7de3-41b9-9f7c-b3794c193c8e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""PlatformGun"",
                    ""type"": ""Button"",
                    ""id"": ""2928caca-344a-4d1c-af5a-e7138b2fda9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                },
                {
                    ""name"": ""Dance"",
                    ""type"": ""Button"",
                    ""id"": ""45d2c063-60a9-458f-ba9b-28039b315bfa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""5f1a33e1-5e9f-4ea8-a934-3fed17459fcc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveNegativeX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c6d8d2a-61b0-4d6c-b26b-6f08fb16d9da"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveNegativeX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e0718670-ee00-469a-b0d0-34fcbd075ca8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""daee87ef-9789-4c83-9827-1572bc52d235"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6f178f76-8c53-421d-88d3-d52a57a79fb6"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""e956f8da-948a-46b5-883d-5cae83ad0ea5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""98e08083-b0c3-4ef0-81e6-252a958ac431"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""7f1278cc-8005-4408-9c42-c1177a30e3d7"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNegativeY"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a560fcfe-6d6f-4f3b-aa8a-37568547bb77"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveNegativeY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4f922f0b-6d76-46b5-b516-07702ea012e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveNegativeY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4d4d2f93-d0ec-4583-be7d-0b0b29b66d8f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""92c70eed-22c0-4121-9190-22f21be77e83"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": ""Normalize(min=-1,max=1),Scale(factor=2)"",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""3fe2d334-aa3e-469d-ac9d-4b23389690b8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6afbfc5c-3032-4802-9b61-ea9ebfab93fb"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6118350b-f470-452e-9728-f5081fddb075"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""37f1aaf4-f99b-4a9c-b4a0-04323d9a821d"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a913af61-ebea-4671-9423-1fbcda76438c"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""6542aa6c-48a0-4f5d-8690-9a4c1bde6231"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""25e15b06-11ba-4759-8b34-665445fe5b6c"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""27b6ec70-17da-4fde-a252-94c40063b874"",
                    ""path"": ""<Mouse>/position/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""583e5138-5571-4cfa-87b1-737ecd84fd38"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2cca2dda-2b86-4950-be5b-c7f1468abfa4"",
                    ""path"": ""<Mouse>/position/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""950ff0c9-b9cb-472b-8a6a-3641a3da3c5a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19714c68-7b17-4664-8141-879e2e60705e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""RotateRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""11a20ef9-0ac2-4072-ae83-28586e037654"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d850bdb8-716b-4691-9c52-b9c1de434417"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a1a786f5-0f78-4418-9cbe-392c64a6aaaf"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""2423906d-29d0-4495-a8a0-2c49544e14c4"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveNegativeX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""down"",
                    ""id"": ""00a1d514-d75c-4dd0-a6e8-ef8b3c3ee02e"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveNegativeX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cb92be54-3ca8-42a4-b0ed-74bd5ebe0cf6"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""MoveNegativeX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28f783b4-8af4-4c6d-aa64-e4a0b5598a64"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Float"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6236122b-5654-4eba-b795-4f254701a5df"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Float"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""89d72770-6be3-448a-ad53-daffd389c3ad"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""NoseDive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93445366-a9cd-47b3-b8f1-3be90121ede5"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""NoseDive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b82b24c8-2b74-483a-931f-795af0d52db3"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""PlatformGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6e278cf-9392-4dfd-a49b-e9db7523e1ec"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""PlatformGun"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""906d7dc4-7c89-4dcf-ba7e-8630e7dc01da"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Dance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8667575c-a632-4b2e-9a0e-e8ff0be32ded"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Dance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Camera"",
            ""id"": ""0816fec7-7378-4904-bd0a-15afef84f681"",
            ""actions"": [
                {
                    ""name"": ""RotateCamera"",
                    ""type"": ""Value"",
                    ""id"": ""ae4a9b33-cb48-4eb3-9a0e-433eac188de8"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Button"",
                    ""id"": ""26170f85-aee5-4ca6-990f-625337c9f85b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""26a6427d-4c5e-405f-97e6-6ccdd987f3f7"",
                    ""expectedControlType"": ""Vector3"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""94d8ab26-1c2f-4d62-8046-d7c4b62a21bd"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3f2d1b3d-e6ff-4904-be41-f51474e436f0"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d93a5e-b66d-401b-8054-64112f68a383"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c836c618-faaf-4b74-8838-9cf8bb64c473"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""76dced52-f80b-45c0-9abe-debf06623fc8"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""dda0d384-ba5d-4e57-ad85-1f76f3cf0dff"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9cfa683c-d281-4e38-8371-9d49a07e63cb"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1151ab0b-17ae-4926-b35a-86270922e25f"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ea02827c-bff2-4230-8de2-ce0fa234bcf3"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RotateCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""32d7a7b4-3b21-4ae8-9523-725d57de0125"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""78c03264-22fa-4e40-9568-ba06e3bf3a16"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""deda1628-2a55-49a5-a232-e7fc4cfa05e1"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cb051339-94ef-4e7d-8125-e9a30cc1cc24"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ca7ca1b-4ec9-4367-a1b8-0bcc884e26c6"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""DanceCombos"",
            ""id"": ""7c394bd6-625b-401f-a482-94fa597f5814"",
            ""actions"": [
                {
                    ""name"": ""PointsDance1"",
                    ""type"": ""Button"",
                    ""id"": ""2d26150a-26eb-4fad-bb13-3f6e7fba262f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointsDance2"",
                    ""type"": ""Button"",
                    ""id"": ""fad5ec72-9293-481f-8f35-9009fbc92d28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointsDance3"",
                    ""type"": ""Button"",
                    ""id"": ""c9da07b4-597d-495a-861b-10b7b011a423"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PointsDance4"",
                    ""type"": ""Button"",
                    ""id"": ""06a18067-329e-4d40-9e75-341aa539f220"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""d580a6e3-6276-4245-8bc2-f9890471344a"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""309ca85a-2e73-4b6e-b9af-551c5e942986"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""bec47489-da85-4d23-abb4-a005236f0ccb"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""2fecc91b-517a-4339-9399-7b8cc00ab2fe"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""8eba3a72-ac16-442b-9c99-3603f950c45b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""c729f14f-454c-4d73-9e38-b3f2e300ab45"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""89f7298d-1fee-445d-8999-454a8bf7abb4"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance3"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""89a42c46-ab11-4d1e-bcf6-61766c2d93af"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""b63f5caa-80a2-4d2b-8237-a3845cffbb18"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Button With One Modifier"",
                    ""id"": ""8321587a-04eb-456f-93b0-8577ba7b5013"",
                    ""path"": ""ButtonWithOneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance4"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""dc6e183a-a669-45d1-8858-af04390fec64"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""button"",
                    ""id"": ""302474db-7d6f-4943-913d-2a9b1bf3c29c"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PointsDance4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""ac8f3555-a235-4c45-acc8-ec4f55ed80ad"",
            ""actions"": [
                {
                    ""name"": ""StartGame"",
                    ""type"": ""Button"",
                    ""id"": ""cbdbfa23-6626-4c88-9c06-f7c1b0160ca5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fa3bba0f-5a64-47ab-90fd-5ca3fc2fc7c9"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""StartGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Touch"",
            ""bindingGroup"": ""Touch"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Joystick"",
            ""bindingGroup"": ""Joystick"",
            ""devices"": [
                {
                    ""devicePath"": ""<Joystick>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XR"",
            ""bindingGroup"": ""XR"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_MoveX = m_Player.FindAction("MoveX", throwIfNotFound: true);
        m_Player_MoveNegativeX = m_Player.FindAction("MoveNegativeX", throwIfNotFound: true);
        m_Player_MoveY = m_Player.FindAction("MoveY", throwIfNotFound: true);
        m_Player_MoveNegativeY = m_Player.FindAction("MoveNegativeY", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        m_Player_Rotate = m_Player.FindAction("Rotate", throwIfNotFound: true);
        m_Player_RotateLeft = m_Player.FindAction("RotateLeft", throwIfNotFound: true);
        m_Player_RotateRight = m_Player.FindAction("RotateRight", throwIfNotFound: true);
        m_Player_Float = m_Player.FindAction("Float", throwIfNotFound: true);
        m_Player_NoseDive = m_Player.FindAction("NoseDive", throwIfNotFound: true);
        m_Player_PlatformGun = m_Player.FindAction("PlatformGun", throwIfNotFound: true);
        m_Player_Dance = m_Player.FindAction("Dance", throwIfNotFound: true);
        // Camera
        m_Camera = asset.FindActionMap("Camera", throwIfNotFound: true);
        m_Camera_RotateCamera = m_Camera.FindAction("RotateCamera", throwIfNotFound: true);
        m_Camera_ChangeCamera = m_Camera.FindAction("ChangeCamera", throwIfNotFound: true);
        m_Camera_Rotate = m_Camera.FindAction("Rotate", throwIfNotFound: true);
        // DanceCombos
        m_DanceCombos = asset.FindActionMap("DanceCombos", throwIfNotFound: true);
        m_DanceCombos_PointsDance1 = m_DanceCombos.FindAction("PointsDance1", throwIfNotFound: true);
        m_DanceCombos_PointsDance2 = m_DanceCombos.FindAction("PointsDance2", throwIfNotFound: true);
        m_DanceCombos_PointsDance3 = m_DanceCombos.FindAction("PointsDance3", throwIfNotFound: true);
        m_DanceCombos_PointsDance4 = m_DanceCombos.FindAction("PointsDance4", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_StartGame = m_UI.FindAction("StartGame", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_MoveX;
    private readonly InputAction m_Player_MoveNegativeX;
    private readonly InputAction m_Player_MoveY;
    private readonly InputAction m_Player_MoveNegativeY;
    private readonly InputAction m_Player_Jump;
    private readonly InputAction m_Player_Rotate;
    private readonly InputAction m_Player_RotateLeft;
    private readonly InputAction m_Player_RotateRight;
    private readonly InputAction m_Player_Float;
    private readonly InputAction m_Player_NoseDive;
    private readonly InputAction m_Player_PlatformGun;
    private readonly InputAction m_Player_Dance;
    public struct PlayerActions
    {
        private @SpaceGnome_02_InputActions m_Wrapper;
        public PlayerActions(@SpaceGnome_02_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @MoveX => m_Wrapper.m_Player_MoveX;
        public InputAction @MoveNegativeX => m_Wrapper.m_Player_MoveNegativeX;
        public InputAction @MoveY => m_Wrapper.m_Player_MoveY;
        public InputAction @MoveNegativeY => m_Wrapper.m_Player_MoveNegativeY;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputAction @Rotate => m_Wrapper.m_Player_Rotate;
        public InputAction @RotateLeft => m_Wrapper.m_Player_RotateLeft;
        public InputAction @RotateRight => m_Wrapper.m_Player_RotateRight;
        public InputAction @Float => m_Wrapper.m_Player_Float;
        public InputAction @NoseDive => m_Wrapper.m_Player_NoseDive;
        public InputAction @PlatformGun => m_Wrapper.m_Player_PlatformGun;
        public InputAction @Dance => m_Wrapper.m_Player_Dance;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @MoveX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveX;
                @MoveNegativeX.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeX;
                @MoveNegativeX.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeX;
                @MoveNegativeX.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeX;
                @MoveY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @MoveY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @MoveY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveY;
                @MoveNegativeY.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeY;
                @MoveNegativeY.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeY;
                @MoveNegativeY.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMoveNegativeY;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Rotate.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotate;
                @RotateLeft.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateLeft;
                @RotateLeft.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateLeft;
                @RotateRight.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateRight;
                @RotateRight.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateRight;
                @RotateRight.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnRotateRight;
                @Float.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
                @Float.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
                @Float.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFloat;
                @NoseDive.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
                @NoseDive.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
                @NoseDive.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnNoseDive;
                @PlatformGun.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformGun;
                @PlatformGun.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformGun;
                @PlatformGun.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnPlatformGun;
                @Dance.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDance;
                @Dance.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDance;
                @Dance.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDance;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MoveX.started += instance.OnMoveX;
                @MoveX.performed += instance.OnMoveX;
                @MoveX.canceled += instance.OnMoveX;
                @MoveNegativeX.started += instance.OnMoveNegativeX;
                @MoveNegativeX.performed += instance.OnMoveNegativeX;
                @MoveNegativeX.canceled += instance.OnMoveNegativeX;
                @MoveY.started += instance.OnMoveY;
                @MoveY.performed += instance.OnMoveY;
                @MoveY.canceled += instance.OnMoveY;
                @MoveNegativeY.started += instance.OnMoveNegativeY;
                @MoveNegativeY.performed += instance.OnMoveNegativeY;
                @MoveNegativeY.canceled += instance.OnMoveNegativeY;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @RotateLeft.started += instance.OnRotateLeft;
                @RotateLeft.performed += instance.OnRotateLeft;
                @RotateLeft.canceled += instance.OnRotateLeft;
                @RotateRight.started += instance.OnRotateRight;
                @RotateRight.performed += instance.OnRotateRight;
                @RotateRight.canceled += instance.OnRotateRight;
                @Float.started += instance.OnFloat;
                @Float.performed += instance.OnFloat;
                @Float.canceled += instance.OnFloat;
                @NoseDive.started += instance.OnNoseDive;
                @NoseDive.performed += instance.OnNoseDive;
                @NoseDive.canceled += instance.OnNoseDive;
                @PlatformGun.started += instance.OnPlatformGun;
                @PlatformGun.performed += instance.OnPlatformGun;
                @PlatformGun.canceled += instance.OnPlatformGun;
                @Dance.started += instance.OnDance;
                @Dance.performed += instance.OnDance;
                @Dance.canceled += instance.OnDance;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Camera
    private readonly InputActionMap m_Camera;
    private ICameraActions m_CameraActionsCallbackInterface;
    private readonly InputAction m_Camera_RotateCamera;
    private readonly InputAction m_Camera_ChangeCamera;
    private readonly InputAction m_Camera_Rotate;
    public struct CameraActions
    {
        private @SpaceGnome_02_InputActions m_Wrapper;
        public CameraActions(@SpaceGnome_02_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @RotateCamera => m_Wrapper.m_Camera_RotateCamera;
        public InputAction @ChangeCamera => m_Wrapper.m_Camera_ChangeCamera;
        public InputAction @Rotate => m_Wrapper.m_Camera_Rotate;
        public InputActionMap Get() { return m_Wrapper.m_Camera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CameraActions set) { return set.Get(); }
        public void SetCallbacks(ICameraActions instance)
        {
            if (m_Wrapper.m_CameraActionsCallbackInterface != null)
            {
                @RotateCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
                @RotateCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotateCamera;
                @ChangeCamera.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @ChangeCamera.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnChangeCamera;
                @Rotate.started -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_CameraActionsCallbackInterface.OnRotate;
            }
            m_Wrapper.m_CameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @RotateCamera.started += instance.OnRotateCamera;
                @RotateCamera.performed += instance.OnRotateCamera;
                @RotateCamera.canceled += instance.OnRotateCamera;
                @ChangeCamera.started += instance.OnChangeCamera;
                @ChangeCamera.performed += instance.OnChangeCamera;
                @ChangeCamera.canceled += instance.OnChangeCamera;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
            }
        }
    }
    public CameraActions @Camera => new CameraActions(this);

    // DanceCombos
    private readonly InputActionMap m_DanceCombos;
    private IDanceCombosActions m_DanceCombosActionsCallbackInterface;
    private readonly InputAction m_DanceCombos_PointsDance1;
    private readonly InputAction m_DanceCombos_PointsDance2;
    private readonly InputAction m_DanceCombos_PointsDance3;
    private readonly InputAction m_DanceCombos_PointsDance4;
    public struct DanceCombosActions
    {
        private @SpaceGnome_02_InputActions m_Wrapper;
        public DanceCombosActions(@SpaceGnome_02_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @PointsDance1 => m_Wrapper.m_DanceCombos_PointsDance1;
        public InputAction @PointsDance2 => m_Wrapper.m_DanceCombos_PointsDance2;
        public InputAction @PointsDance3 => m_Wrapper.m_DanceCombos_PointsDance3;
        public InputAction @PointsDance4 => m_Wrapper.m_DanceCombos_PointsDance4;
        public InputActionMap Get() { return m_Wrapper.m_DanceCombos; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DanceCombosActions set) { return set.Get(); }
        public void SetCallbacks(IDanceCombosActions instance)
        {
            if (m_Wrapper.m_DanceCombosActionsCallbackInterface != null)
            {
                @PointsDance1.started -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance1;
                @PointsDance1.performed -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance1;
                @PointsDance1.canceled -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance1;
                @PointsDance2.started -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance2;
                @PointsDance2.performed -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance2;
                @PointsDance2.canceled -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance2;
                @PointsDance3.started -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance3;
                @PointsDance3.performed -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance3;
                @PointsDance3.canceled -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance3;
                @PointsDance4.started -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance4;
                @PointsDance4.performed -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance4;
                @PointsDance4.canceled -= m_Wrapper.m_DanceCombosActionsCallbackInterface.OnPointsDance4;
            }
            m_Wrapper.m_DanceCombosActionsCallbackInterface = instance;
            if (instance != null)
            {
                @PointsDance1.started += instance.OnPointsDance1;
                @PointsDance1.performed += instance.OnPointsDance1;
                @PointsDance1.canceled += instance.OnPointsDance1;
                @PointsDance2.started += instance.OnPointsDance2;
                @PointsDance2.performed += instance.OnPointsDance2;
                @PointsDance2.canceled += instance.OnPointsDance2;
                @PointsDance3.started += instance.OnPointsDance3;
                @PointsDance3.performed += instance.OnPointsDance3;
                @PointsDance3.canceled += instance.OnPointsDance3;
                @PointsDance4.started += instance.OnPointsDance4;
                @PointsDance4.performed += instance.OnPointsDance4;
                @PointsDance4.canceled += instance.OnPointsDance4;
            }
        }
    }
    public DanceCombosActions @DanceCombos => new DanceCombosActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_StartGame;
    public struct UIActions
    {
        private @SpaceGnome_02_InputActions m_Wrapper;
        public UIActions(@SpaceGnome_02_InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @StartGame => m_Wrapper.m_UI_StartGame;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                @StartGame.started -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
                @StartGame.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnStartGame;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                @StartGame.started += instance.OnStartGame;
                @StartGame.performed += instance.OnStartGame;
                @StartGame.canceled += instance.OnStartGame;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_TouchSchemeIndex = -1;
    public InputControlScheme TouchScheme
    {
        get
        {
            if (m_TouchSchemeIndex == -1) m_TouchSchemeIndex = asset.FindControlSchemeIndex("Touch");
            return asset.controlSchemes[m_TouchSchemeIndex];
        }
    }
    private int m_JoystickSchemeIndex = -1;
    public InputControlScheme JoystickScheme
    {
        get
        {
            if (m_JoystickSchemeIndex == -1) m_JoystickSchemeIndex = asset.FindControlSchemeIndex("Joystick");
            return asset.controlSchemes[m_JoystickSchemeIndex];
        }
    }
    private int m_XRSchemeIndex = -1;
    public InputControlScheme XRScheme
    {
        get
        {
            if (m_XRSchemeIndex == -1) m_XRSchemeIndex = asset.FindControlSchemeIndex("XR");
            return asset.controlSchemes[m_XRSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMoveX(InputAction.CallbackContext context);
        void OnMoveNegativeX(InputAction.CallbackContext context);
        void OnMoveY(InputAction.CallbackContext context);
        void OnMoveNegativeY(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnRotateLeft(InputAction.CallbackContext context);
        void OnRotateRight(InputAction.CallbackContext context);
        void OnFloat(InputAction.CallbackContext context);
        void OnNoseDive(InputAction.CallbackContext context);
        void OnPlatformGun(InputAction.CallbackContext context);
        void OnDance(InputAction.CallbackContext context);
    }
    public interface ICameraActions
    {
        void OnRotateCamera(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
    }
    public interface IDanceCombosActions
    {
        void OnPointsDance1(InputAction.CallbackContext context);
        void OnPointsDance2(InputAction.CallbackContext context);
        void OnPointsDance3(InputAction.CallbackContext context);
        void OnPointsDance4(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnStartGame(InputAction.CallbackContext context);
    }
}
