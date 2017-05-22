using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _rotateSpeed = 5.0f;
    private float _forwardSpeed = 10.0f;
    private CharacterController _playerController;

    void Start()
    {
        _playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") && _playerController.isGrounded)
        {
            _playerController.Move(Vector3.up);
            Debug.Log("jump");
        }

        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotateSpeed, 0);

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = _forwardSpeed * Input.GetAxis("Vertical");
        _playerController.SimpleMove(forward * curSpeed);
    }
}