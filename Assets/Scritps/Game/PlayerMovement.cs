using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float movementVelocity;
    float xAxis;
    float zAxis;
    float smooth;
    Vector3 newPosition;

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
        newPosition = new Vector3(xAxis * smooth, 0f, zAxis * smooth);
    }

        void PlayerMove()
    {
        transform.Translate(newPosition);
    }
}
