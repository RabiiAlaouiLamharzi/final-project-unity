using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class MovementProvider : LocomotionSystem
{
    public float speed = 2.0f;                     
    public float gravityMultiplier = 1.0f;         
    public List<XRController> controllers = null; 
    private CharacterController characterController; 
    private GameObject head;                       

    protected void Awake()
    {
        characterController = GetComponent<CharacterController>();
        head = GetComponent<XRRig>().cameraGameObject;
    }

    void Start()
    {
        PositionController();
    }

    private void PositionController()
    {
        float headHeight = Mathf.Clamp(head.transform.localPosition.y, 1, 2);
        characterController.height = headHeight;
        Vector3 newCenter = new Vector3(head.transform.localPosition.x, headHeight / 2 + characterController.skinWidth, head.transform.localPosition.z);
        characterController.center = newCenter;
        Debug.Log($"Time: {Time.time} | Head height: {headHeight}");
    }

    protected new void Update()
    {
        PositionController();
        CheckForInput();
        ApplyGravity();
    }

    private void CheckForInput()
    {
        foreach (XRController controller in controllers)
        {
            if (controller.enableInputActions)
            {
                CheckForMovement(controller.inputDevice);
            }
        }
    }

    private void CheckForMovement(InputDevice device)
    {
        if (device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position))
        {
            StartMove(position);
        }
    }

    private void StartMove(Vector2 position)
    {
        Vector3 direction = new Vector3(position.x, 0, position.y);
        Vector3 headRotation = new Vector3(0, head.transform.eulerAngles.y, 0);
        direction = Quaternion.Euler(headRotation) * direction;
        Vector3 movement = direction * speed;

        characterController.Move(movement * Time.deltaTime);
    }

    private void ApplyGravity()
    {
        Vector3 gravity = new Vector3(0, Physics.gravity.y * gravityMultiplier, 0);
        characterController.Move(gravity * Time.deltaTime);
    }
}
