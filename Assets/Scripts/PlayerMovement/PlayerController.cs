using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float RotateSpeed = 10.0f;
    public float ForwardSpeed;
    private CharacterController _playerController;

    void Start()
    {
        _playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") /*&& _playerController.isGrounded*/)
        {
            _playerController.Move(Vector3.up);
            Debug.Log("jump");
        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * RotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
    }
}