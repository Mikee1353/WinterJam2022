using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Movement")]
    public float moveSpeed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 MoveDirection;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation= true;
    }

    private void FixedUpdate()
    {
        MovePlayer();   
    }

    private void Update()
    {
        MyInput();        
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
    }

    private void MovePlayer()
    {
        
        MoveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
      
        rb.AddForce(MoveDirection.normalized * moveSpeed * 10, ForceMode.Force);
        rb.velocity = rb.velocity * 0.979f;

    }
}
