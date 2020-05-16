using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        moveForward();
        moveBackward();
        rotateLeft();
        rotateRight();
    }

    private void moveForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
    }
    private void moveBackward()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
    }
    private void rotateLeft()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, 5f, 0f);
        }
    }
    private void rotateRight()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, -5f, 0f);
        }
    }
}
