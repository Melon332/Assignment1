using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    CharacterController controller;

    Vector3 moveDirection = Vector3.zero;

    [SerializeField] float speed;

    float gravity = 5;

    InputManager inputs;
    // Start is called before the first frame update
    void Start()
    {

        controller = GetComponent<CharacterController>();
        Debug.Log(controller.isGrounded);

        speed = 15;

        inputs = GetComponent<InputManager>();
        inputs.movement += Inputs_movement;
    }
    private void Update()
    {
        moveDirection.y -= gravity * Time.deltaTime;
        //Making the character move
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void Inputs_movement(object sender, (float, float) e)
    {
        Move(e.Item1, e.Item2);
    }

    public void Move(float vertical, float horizontal)
    {
        if (controller.isGrounded)
        {
            //Feed moveDirection with input.
            moveDirection = new Vector3(horizontal, 0, vertical);
            moveDirection = transform.TransformDirection(moveDirection);
            //Multiply it by speed.
            moveDirection *= speed;
            Debug.Log(moveDirection);
        }
    }
}
