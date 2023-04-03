using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f; // Movement speed of the object
    public float rotateSpeed = 100f; // Rotation speed of the object

    void Update()
    {
        // Get horizontal and vertical input values (ASDW, arrow keys)
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Calculate movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized * speed * Time.deltaTime;

        // Move the object in the direction of the movement vector
        transform.Translate(movement, Space.Self);

        // Rotate the object left or right when A or D is pressed respectively
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotateSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
        }
    }
}
