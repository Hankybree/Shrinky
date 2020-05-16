using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
    [SerializeField] float jumpForce;

    private Rigidbody rb;
    private bool isGrounded;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        Movement();
    }

    private void OnCollisionStay()
    {
        Debug.Log("Collided");
        isGrounded = true;
    }

    private void Movement()
    {
        MoveForward();
        MoveBackward();
        RotateLeft();
        RotateRight();
        Jump();
    }

    private void MoveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    private void MoveBackward()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
    private void RotateLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, rotateSpeed, 0f);
        }
    }
    private void RotateRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, rotateSpeed * -1, 0f);
        }
    }

    private void Jump()
    {
        if(Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
