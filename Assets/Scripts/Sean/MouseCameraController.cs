using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraController : MonoBehaviour
{
    public float mouseSensitivity = 2.0f; // Adjust sensitivity here
    public bool lockCursor = true;

    private float xRotation = 0f;
    private float yRotation = 0f;

    void Start()
    {
        if (lockCursor)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate the camera
        yRotation += mouseX;
        xRotation -= mouseY;

        // Limit vertical rotation to prevent looking upside down
        xRotation = Mathf.Clamp(xRotation, -90, 90);

        // Apply rotation to the camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
    }
}