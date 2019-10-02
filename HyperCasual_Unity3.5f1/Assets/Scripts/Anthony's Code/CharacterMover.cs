using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    private CharacterController controller;
    private Vector3 position;
    public IntData jumpData;
  
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;

        if (Input.GetButton("Jump") && jumpData.value < jumpData.maxValue)
        {
            position.y = jumpSpeed;
            jumpData.value++;
        } else if (controller.isGrounded)
        {
            position.y = 0;
        }
        controller.Move(position * Time.deltaTime);
    }
}
