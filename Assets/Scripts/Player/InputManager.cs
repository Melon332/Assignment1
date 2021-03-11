using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public event EventHandler<(float, float)> movement;

    float vertical, horizontal;

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        InputMovement();
    }

    public void InputMovement()
    {
        if (vertical != 0 || horizontal != 0)
        {
            movement?.Invoke(this, (vertical, horizontal));
        }
    }
}
