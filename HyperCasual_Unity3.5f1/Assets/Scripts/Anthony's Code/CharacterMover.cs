using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[RequireComponent((typeof(CharacterController)))] //Puts the character controller (Required Component on the unity asset by default

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 10f, jumpSpeed = 30f, gravity = 3f;
    private Vector3 position;
    private int jumpCount;
    public int jumpCountMax = 2;
    
        
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");
        position.z = moveSpeed * Input.GetAxis("Vertical");
        position.y -= gravity;
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }
        controller.Move(motion:position * Time.deltaTime);

    }
}
