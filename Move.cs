using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;

    float moveSpeed = 0f;
    bool jump = false;
    bool crouch = false;
    // Update is called once per frameD
    void Update()
    {
        moveSpeed = Input.GetAxisRaw("Horizontal") * runSpeed;
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }else if (Input.GetButtonDown("Crouch"))
        {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(moveSpeed * Time.fixedDeltaTime,crouch,jump);
        jump = false;
    }
}
