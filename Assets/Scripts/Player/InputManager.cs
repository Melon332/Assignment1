using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event EventHandler<(float, float)> movement;
    public event EventHandler<(float, float)> mouseMovement;

    float vertical, horizontal;

    float mouseSens = 90f;

    float mouseX, mouseY;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSens;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSens;

        InputMovement();
        InputCameraMovement();
    }

    public void InputMovement()
    {
        if (vertical != 0 || horizontal != 0)
        {
            movement?.Invoke(this, (vertical, horizontal));
        }
    }
    
    public void InputCameraMovement()
    {
        if(mouseX != 0 || mouseY != 0)
        {
            mouseMovement?.Invoke(this, (mouseX, mouseY));
        }
    }
}
