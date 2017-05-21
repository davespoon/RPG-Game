using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public float rotateSpeed = 100f;

    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
            //transform.Translate((Vector3.left) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
            //transform.Translate((Vector3.right) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButton(0))
        {
            moveSpeed = 20.0f;
        }

        if (!Input.GetMouseButton(0))
        {
            moveSpeed = 10.0f;
        }
    }
}