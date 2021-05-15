using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    CharacterController controller;
    [SerializeField] float movementVelocity;
    float xAxis;
    float zAxis;
    float smooth;
    Vector3 newPosition;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        UpdateAxis();
        UpdateNewPosition();
        PlayerMove();
    }

    void UpdateAxis()
    {
        xAxis = Input.GetAxis("Horizontal");
        zAxis = Input.GetAxis("Vertical");
    }

    void UpdateNewPosition()
    {
        smooth = Time.deltaTime * movementVelocity;
        newPosition =  transform.right * xAxis + transform.forward * zAxis;
    }

        void PlayerMove()
    {
        controller.Move(newPosition * smooth);
    }
}
