using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController3D : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnSpeed = 5.0f;
    public float jumpForce = 5.0f;

    private float verticalInput;
    private float horizontalInput;
    private Rigidbody rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        // Movement
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up,Time.deltaTime * turnSpeed * horizontalInput);
        // Animator control for running

        // Jumping
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("hi");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}