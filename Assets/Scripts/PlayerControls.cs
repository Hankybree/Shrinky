using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        MoveBackward();
        RotateLeft();
        RotateRight();
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
}
